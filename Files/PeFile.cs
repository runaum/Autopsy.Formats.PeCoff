using System;
using System.Collections.Generic;
using System.IO;
using Autopsy.Formats.PeCoff.Common;
using Autopsy.Formats.PeCoff.Headers;
using Autopsy.Formats.PeCoff.Sections;

namespace Autopsy.Formats.PeCoff.Files
{
    public class PeFile: BinaryHelper
    {
        public DosHeader DosHeader;

        public byte[] DosStubProgram;

        public NtHeader NtHeader;

        public List<SectionHeader> SectionHeaders;

        public FileHeader FileHeader
        { 
            get 
            { 
                return NtHeader != null ? NtHeader.FileHeader : null; 
            }
            set
            {
                if (NtHeader == null)
                    NtHeader = NtHeader.Default;

                NtHeader.FileHeader = value;
            }
        }

        public OptionalHeader OptionalHeader
        {
            get
            {
                return NtHeader != null ? NtHeader.OptionalHeader : null;
            }
            set
            {
                if (NtHeader == null)
                    NtHeader = NtHeader.Default;

                NtHeader.OptionalHeader = value;
            }
        }

        // TODO: Validate algo, some cases doesn't checked
        // TODO: REFACTOR ME!
        public long VAToOffset(long virtualAddress)
        {
            if (SectionHeaders == null)
                throw new Exception("No sections to calc an offset");

            var section = LocateVA(virtualAddress);
            if (section == null)
                return -1;

            return section.PointerToRawData + (virtualAddress - section.VirtualAddress);
        }

        // TODO: Validate algo, some cases doesn't checked
        // TODO: REFACTOR ME!
        public SectionHeader LocateVA(long virtualAddress)
        {
            if (SectionHeaders == null)
                throw new Exception("No sections to calc an offset");

            foreach (var section in SectionHeaders)
            {
                if (virtualAddress >= section.VirtualAddress &&
                    virtualAddress < (section.VirtualAddress + section.SizeOfRawData))
                    return section;
            }
            return null;
        }

        protected override void ReadInternal(Stream stream)
        {
            // Read IMAGE_DOS_HEADER
            DosHeader = MarshalAt<DosHeader>(0);
            if (!DosHeader.IsValid)
                throw new Exception("Invalid DOS header");

            // Read DOS stub program
            var stubSize = DosHeader.e_lfanew - Stream.Position;
            DosStubProgram = Reader.ReadBytes((int)stubSize);

            // Read IMAGE_NT_HEADER (both archs)
            NtHeader = new NtHeader(this);
            if (!NtHeader.IsValid)
                throw new Exception("Invalid PE header");

            // Read sections
            var sectionCount = NtHeader.FileHeader.NumberOfSections;
            SectionHeaders = new List<SectionHeader>(sectionCount + 1);
            for (int i = 0; i < sectionCount; i++)
                SectionHeaders.Add(MarshalAt<SectionHeader>());
        }

        public PeFile(string fileName)
        {
            using (var stream = File.OpenRead(fileName))
            {
                Read(stream);
            }
        }

        public PeFile(Stream stream)
        {
            Read(stream);
        }

        public static PeFile Load(string fileName)
        {
            return new PeFile(fileName);
        }

        public static PeFile Load(Stream stream)
        {
            return new PeFile(stream);
        }
    }
}
