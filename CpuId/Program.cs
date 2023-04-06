using System;
using LibCpuId;

namespace CpuId {
	class MainClass {
		public static void Main() {
			var libCpuId = new LibCpuId.LibCpuId();

			Console.WriteLine(" eax in    eax      ebx      ecx      edx");
			foreach(var dict in libCpuId.RawData) {
				CpuRegisters regs = dict.Value;
				Console.WriteLine("{0:x8} {1:x8} {2:x8} {3:x8} {4:x8}", dict.Key, regs.eax, regs.ebx, regs.ecx, regs.edx);
			}
			Console.WriteLine();
			Console.WriteLine("Vendor ID: \"{0}\"; CPUID level {1}", libCpuId.VendorId, libCpuId.CpuIdLevel);
			Console.WriteLine();
			if (libCpuId.VendorId.EndsWith("Intel")) {
				Console.WriteLine("Intel-specific functions:");
				Console.WriteLine("Version {0:x8}:", libCpuId.ProcessorInfo.Raw);
				Console.WriteLine("Type {0}", libCpuId.ProcessorInfo.ProcessorType);
				Console.WriteLine("Family {0}", libCpuId.ProcessorInfo.Family);
				Console.WriteLine("Model {0}", libCpuId.ProcessorInfo.Model);
				Console.WriteLine("Stepping {0}", libCpuId.ProcessorInfo.Stepping);
				Console.WriteLine("Reserved {0}");
				Console.WriteLine();
			}
			Console.WriteLine("Extended brand string: \"{0}\"", libCpuId.ProcessorBrandString);
			Console.WriteLine();

			Console.WriteLine("Feature flags:");
			foreach(FeatureBitObject featureBit in libCpuId.FeatureBits) {
				if (featureBit.Value) {
					if (featureBit.Abbreviation != String.Empty) {
						Console.WriteLine(featureBit.Abbreviation + " - " + featureBit.LongName);
					} else {
						Console.WriteLine(featureBit.Name);
					}
				}
			}
		}
	}
}
