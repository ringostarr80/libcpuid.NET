using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace LibCpuId {
	public enum FeatureBit {
		// ecx Register
		PrescottNewInstructions,
		PCLMULQDQ,
		DebugStore64Bit,
		MONITORAndMWAITInstructions,
		CPLQualifiedDebugStore,
		VirtualMachineExtensions,
		SaferModeExtensions,
		EnhancedSpeedStep,
		ThermalMonitor2,
		SupplementalSSE3Instructions,
		ContextID,
		FusedMultiplyAdd,
		CMPXCHG16BInstruction,
		CanDisableSendingTaskPriorityMessages,
		PerfmonAndDebugCapability,
		ProcessContextIdentifiers,
		DirectCacheAccessForDMAWrites,
		SSE4_1Instructions,
		SSE4_2Instructions,
		x2APICSupport,
		MOVBEInstruction,
		POPCNTInstruction,
		TSCDeadlineSupport,
		AESInstructionSet,
		XSAVE_XRESTOR_XSETBV_XGETBV_Support,
		XSAVEEnabledByOS,
		AdvancedVectorExtensions,
		CVT16InstructionSet,
		RDRANDSupport,
		RunningOnAHypervisor,

		// edx Register
		Onboardx87FPU,
		VirtualModeExtensions,
		DebuggingExtensions,
		PageSizeExtension,
		TimeStampCounter,
		ModelSpecificRegisters,
		PhysicalAddressExtension,
		MachineCheckException,
		CMPXCHG8Instruction,
		OnboardAPIC,
		SYSENTERAndSYSEXITInstructions,
		MemoryTypeRangeRegisters,
		PageGlobalEnableBitInCR4,
		MachineCheckArchitecture,
		ConditionalMoveAndFCMOVInstructions,
		PageAttributeTable,
		PageSizeExtension36Bit,
		ProcessorSerialNumber,
		CLFLUSHInstruction,
		DebugStore,
		OnboardThermalControlMSRsForACPI,
		MMXInstructions,
		FXSAVE_FXRESTOR_Instructions,
		SSEInstructions,
		SSE2Instructions,
		CPUCacheSupportsSelfSnoop,
		HyperThreading,
		ThermalMonitorAuomaticallyLimitsTemperature,
		IA64ProcessorEmulatingx86,
		PendingBreakEnableWakeupSupport,

		// extended features

		// ecx Register
		LAHF_SAHF_InLongMode,
		HyperThreadingNotValid,
		SecureVirtualMachine,
		ExtendedAPICSpace,
		CR8In32BitMode,
		AdvancedBitManipulation,
		SSE4a,
		MisalignedSSEMode,
		PREFETCHAndPREFETCHWInstructions,
		OSVisibleWorkaround,
		InstructionBasedSampling,
		XOPInstructionSet,
		SKINIT_STGI_Instructions,
		WatchdogTimer,
		LightweightProfiling,
		FourOperandsFusedMultiplyAdd,
		TranslationCacheExtension,
		NodeID_MSR,
		TrailingBitManipulation,
		TopologyExtensions,
		CorePerformanceCounterExtensions,
		NBPerformanceCounterExtensions,

		// edx Register
		SYSCALLAndSYSRETInstructions,
		MultiprocessorCapable,
		NXBit,
		ExtendedMMX,
		FXSAVE_FXRSTOR_Instructions,
		FXSAVE_FXRSTOR_Optimizations,
		GibibytePages,
		RDTSCPInstruction,
		LongMode,
		Extended3DNow,
		AMD3DNow
	}
	;

	public struct CpuRegisters {
		public UInt32 eax;
		public UInt32 ebx;
		public UInt32 ecx;
		public UInt32 edx;
	}

	public struct ProcessorInfo {
		public UInt16 Stepping;
		public UInt16 Model;
		public UInt16 Family;
		public UInt16 ProcessorType;
		public UInt16 ExtendedModel;
		public UInt16 ExtendedFamily;
		public UInt32 Raw;
	}

	public struct FeatureBits : IEnumerable {
		// ecx Register
		[FeatureBit("PNI", "Prescott New Instructions (SSE3)")]
		public bool
			PrescottNewInstructions;
		[FeatureBit("PCLMULQDQ", " PCLMULQDQ support")]
		public bool
			PCLMULQDQ;
		[FeatureBit("DTES64", "64-bit debug store")]
		public bool
			DebugStore64Bit;
		[FeatureBit("monitor", "MONITOR and MWAIT instructions")]
		public bool
			MONITORAndMWAITInstructions;
		[FeatureBit("DS_CPL", "CPL qualified debug store")]
		public bool
			CPLQualifiedDebugStore;
		[FeatureBit("VMX", "Virtual Machine eXtensions")]
		public bool
			VirtualMachineExtensions;
		[FeatureBit("SMX", "Safer Mode Extensions (LaGrande)")]
		public bool
			SaferModeExtensions;
		[FeatureBit("EST", "Enhanced SpeedStep")]
		public bool
			EnhancedSpeedStep;
		[FeatureBit("TM2", "Thermal Monitor 2")]
		public bool
			ThermalMonitor2;
		[FeatureBit("SSSE3", "Supplemental SSE3 instructions")]
		public bool
			SupplementalSSE3Instructions;
		[FeatureBit("CID", "Context ID")]
		public bool
			ContextID;
		[FeatureBit("FMA", "Fused multiply-add (FMA3)")]
		public bool
			FusedMultiplyAdd;
		[FeatureBit("CX16", "CMPXCHG16B Instruction")]
		public bool
			CMPXCHG16BInstruction;
		[FeatureBit("XTPR", "Can disable sending task priority messages")]
		public bool
			CanDisableSendingTaskPriorityMessages;
		[FeatureBit("PDCM", "Perfmon & debug capability")]
		public bool
			PerfmonAndDebugCapability;
		[FeatureBit("PCID", "Process context identifiers (CR4 bit 17)")]
		public bool
			ProcessContextIdentifiers;
		[FeatureBit("DCA", "Direct cache access for DMA writes")]
		public bool
			DirectCacheAccessForDMAWrites;
		[FeatureBit("SSE4_1", "SSE4.1 instructions")]
		public bool
			SSE4_1Instructions;
		[FeatureBit("SSE4_2", "SSE4.2 instructions")]
		public bool
			SSE4_2Instructions;
		[FeatureBit("X2APIC", "x2APIC support")]
		public bool
			x2APICSupport;
		[FeatureBit("movbe", "MOVBE instruction (big-endian, Intel Atom only)")]
		public bool
			MOVBEInstruction;
		[FeatureBit("POPCNT", "POPCNT instruction")]
		public bool
			POPCNTInstruction;
		[FeatureBit("TSCDEADLINE", "APIC supports one-shot operation using a TSC deadline value")]
		public bool
			TSCDeadlineSupport;
		[FeatureBit("AES", "AES instruction set")]
		public bool
			AESInstructionSet;
		[FeatureBit("XSAVE", "XSAVE, XRESTOR, XSETBV, XGETBV")]
		public bool
			XSAVE_XRESTOR_XSETBV_XGETBV_Support;
		[FeatureBit("OSXSAVE", "XSAVE enabled by OS")]
		public bool
			XSAVEEnabledByOS;
		[FeatureBit("AVX", "Advanced Vector Extensions")]
		public bool
			AdvancedVectorExtensions;
		[FeatureBit("F16C", "CVT16 instruction set (half-precision) FP support")]
		public bool
			CVT16InstructionSet;
		[FeatureBit("RDRND", "RDRAND (on-chip random number generator) support")]
		public bool
			RDRANDSupport;
		[FeatureBit("hypervisor", "Running on a hypervisor (always 0 on a real CPU, but also with some hypervisors)")]
		public bool
			RunningOnAHypervisor;

		// edx Register
		[FeatureBit("FPU", "Onboard x87 FPU")]
		public bool
			Onboardx87FPU;
		[FeatureBit("VME", "Virtual mode extensions (VIF)")]
		public bool
			VirtualModeExtensions;
		[FeatureBit("de", "Debugging extensions (CR4 bit 3)")]
		public bool
			DebuggingExtensions;
		[FeatureBit("PSE", "Page Size Extension")]
		public bool
			PageSizeExtension;
		[FeatureBit("TSC", "Time Stamp Counter")]
		public bool
			TimeStampCounter;
		[FeatureBit("MSR", "Model-specific registers")]
		public bool
			ModelSpecificRegisters;
		[FeatureBit("PAE", "Physical Address Extension")]
		public bool
			PhysicalAddressExtension;
		[FeatureBit("MCE", "Machine Check Exception")]
		public bool
			MachineCheckException;
		[FeatureBit("CX8", "CMPXCHG8 (compare-and-swap) instruction")]
		public bool
			CMPXCHG8Instruction;
		[FeatureBit("APIC", "Onboard Advanced Programmable Interrupt Controller")]
		public bool
			OnboardAPIC;
		[FeatureBit("SEP", "SYSENTER and SYSEXIT instructions")]
		public bool
			SYSENTERAndSYSEXITInstructions;
		[FeatureBit("MTRR", "Memory Type Range Registers")]
		public bool
			MemoryTypeRangeRegisters;
		[FeatureBit("PGE", "Page Global Enable bit in CR4")]
		public bool
			PageGlobalEnableBitInCR4;
		[FeatureBit("MCA", "Machine check architecture")]
		public bool
			MachineCheckArchitecture;
		[FeatureBit("CMOV", "Conditional move and FCMOV instructions")]
		public bool
			ConditionalMoveAndFCMOVInstructions;
		[FeatureBit("PAT", "Page Attribute Table")]
		public bool
			PageAttributeTable;
		[FeatureBit("PSE36", "36-bit page size extension")]
		public bool
			PageSizeExtension36Bit;
		[FeatureBit("PN", "Processor Serial number")]
		public bool
			ProcessorSerialNumber;
		[FeatureBit("CLFLUSH", "CLFLUSH instruction (SSE2)")]
		public bool
			CLFLUSHInstruction;
		[FeatureBit("DTS", "Debug store: save trace of executed jumps")]
		public bool
			DebugStore;
		[FeatureBit("ACPI", "Onboard thermal control MSRs for ACPI")]
		public bool
			OnboardThermalControlMSRsForACPI;
		[FeatureBit("MMX", "MMX instructions")]
		public bool
			MMXInstructions;
		[FeatureBit("FXSR", "FXSAVE, FXRESTOR instructions, CR4 bit 9")]
		public bool
			FXSAVE_FXRESTOR_Instructions;
		[FeatureBit("SSE", "SSE instructions (a.k.a. Katmai New Instructions)")]
		public bool
			SSEInstructions;
		[FeatureBit("SSE2", "SSE2 instructions")]
		public bool
			SSE2Instructions;
		[FeatureBit("SS", "CPU cache supports self-snoop")]
		public bool
			CPUCacheSupportsSelfSnoop;
		[FeatureBit("ht", "Hyper-threading")]
		public bool
			HyperThreading;
		[FeatureBit("TM", "Thermal montitor automatically limits temperature")]
		public bool
			ThermalMonitorAuomaticallyLimitsTemperature;
		[FeatureBit("IA64", "IA64 processor emulating x86")]
		public bool
			IA64ProcessorEmulatingx86;
		[FeatureBit("PBE", "Pending Break Enable (PBE# pin) wakeup support")]
		public bool
			PendingBreakEnableWakeupSupport;

		// extended features

		// ecx Register
		[FeatureBit("LAHF_LM", "LAHF/SAHF in long mode")]
		public bool
			LAHF_SAHF_InLongMode;
		[FeatureBit("CMP_LEGACY", "Hyperthreading not valid")]
		public bool
			HyperThreadingNotValid;
		[FeatureBit("SVM", "Secure Virtual Machine")]
		public bool
			SecureVirtualMachine;
		[FeatureBit("EXTAPIC", "Extended APIC space")]
		public bool
			ExtendedAPICSpace;
		[FeatureBit("CR8_LEGACY", "CR8 in 32-bit mode")]
		public bool
			CR8In32BitMode;
		[FeatureBit("ABM", "Advanced bit manipulation (lzcnt and popcnt)")]
		public bool
			AdvancedBitManipulation;
		[FeatureBit("SSE4A", "SSE4a")]
		public bool
			SSE4a;
		[FeatureBit("MISALIGNSSE", "Misaligned SSE mode")]
		public bool
			MisalignedSSEMode;
		[FeatureBit("3DNOWPREFETCH", "PREFETCH nad PREFETCHW instructions")]
		public bool
			PREFETCHAndPREFETCHWInstructions;
		[FeatureBit("OSVW", "OS Visible Workaround")]
		public bool
			OSVisibleWorkaround;
		[FeatureBit("IBS", "Instruction Based Sampling")]
		public bool
			InstructionBasedSampling;
		[FeatureBit("XOP", "XOP instruction set")]
		public bool
			XOPInstructionSet;
		[FeatureBit("SKINIT", "SKINIT/STGI instructions")]
		public bool
			SKINIT_STGI_Instructions;
		[FeatureBit("WDT", "Watchdog timer")]
		public bool
			WatchdogTimer;
		[FeatureBit("LWP", "Light Weight Profiling")]
		public bool
			LightweightProfiling;
		[FeatureBit("FMA4", "4 operands fused multiply-add")]
		public bool
			FourOperandsFusedMultiplyAdd;
		[FeatureBit("TCE", "Translation Cache Extension")]
		public bool
			TranslationCacheExtension;
		[FeatureBit("NODEID_MSR", "NodeId MSR")]
		public bool
			NodeID_MSR;
		[FeatureBit("TBM", "Trailing Bit Manipulation")]
		public bool
			TrailingBitManipulation;
		[FeatureBit("TOPOEXT", "Topology Extensions")]
		public bool
			TopologyExtensions;
		[FeatureBit("PERFCTR_CORE", "Core performance counter extensions")]
		public bool
			CorePerformanceCounterExtensions;
		[FeatureBit("PERFCTR_NB", "NB performance counter extensions")]
		public bool
			NBPerformanceCounterExtensions;

		// edx Register
		[FeatureBit("SYSCALL", "SYSCALL and SYSRET instructions")]
		public bool
			SYSCALLAndSYSRETInstructions;
		[FeatureBit("MP", "Multiprocessor Capable")]
		public bool
			MultiprocessorCapable;
		[FeatureBit("NX", "NX bit")]
		public bool
			NXBit;
		[FeatureBit("MMXEXT", "Extended MMX")]
		public bool
			ExtendedMMX;
		[FeatureBit("FXSR", "FXSAVE, FXRSTOR instructions, CR4 bit 9")]
		public bool
			FXSAVE_FXRSTOR_Instructions;
		[FeatureBit("FXSR_OPT", "FXSAVE/FXRSTOR optimizations")]
		public bool
			FXSAVE_FXRSTOR_Optimizations;
		[FeatureBit("PDPE1GB", "Gibibyte pages")]
		public bool
			GibibytePages;
		[FeatureBit("RDTSCP", "RDTSCP instruction")]
		public bool
			RDTSCPInstruction;
		[FeatureBit("LM", "Long mode")]
		public bool
			LongMode;
		[FeatureBit("3DNOWEXT", "Extended 3DNow!")]
		public bool
			Extended3DNow;
		[FeatureBit("3DNow", "3DNow!")]
		public bool
			AMD3DNow;

		public IEnumerator GetEnumerator() {
			FieldInfo[] infos = this.GetType().GetFields();

			ArrayList list = new();
			foreach(FieldInfo info in infos) {
				bool featureBitAttributeFound = false;
				object[] attributes = info.GetCustomAttributes(false);
				foreach(var attribute in attributes) {
					if (attribute.GetType().Name == "FeatureBitAttribute") {
						featureBitAttributeFound = true;
						FeatureBitAttribute featureBitAttribute = (FeatureBitAttribute)attribute;
						list.Add(new FeatureBitObject(info.Name, (bool)info.GetValue(this), featureBitAttribute.Abbreviation, featureBitAttribute.LongName));
					}
				}
				if (!featureBitAttributeFound) {
					list.Add(new FeatureBitObject(info.Name, (bool)info.GetValue(this)));
				}
			}

			return list.GetEnumerator();
		}
	}

	public readonly struct FeatureBitObject {
		private readonly string _name;
		private readonly bool _value;
		private readonly string _abbreviation;
		private readonly string _longName;

		public string Name { get { return this._name; } }
		public bool Value { get { return this._value; } }
		public string Abbreviation { get { return this._abbreviation; } }
		public string LongName { get { return this._longName; } }

		public FeatureBitObject(string name, bool value) {
			this._name = name;
			this._value = value;
			this._abbreviation = String.Empty;
			this._longName = String.Empty;
		}

		public FeatureBitObject(string name, bool value, string abbreviation, string longName) {
			this._name = name;
			this._value = value;
			this._abbreviation = abbreviation;
			this._longName = longName;
		}
	}

	public partial class LibCpuId {
		private readonly Dictionary<UInt32, CpuRegisters> _rawData = new();
		private uint _cpuidLevel = 0;
		private string _vendorId = String.Empty;
		private string _processorBrandString = String.Empty;
		private FeatureBits _featureBits;
		private ProcessorInfo _processorInfo;

		public Dictionary<UInt32, CpuRegisters> RawData { get { return this._rawData; } }
		public uint CpuIdLevel { get { return this._cpuidLevel; } }
		public string VendorId { get { return this._vendorId; } }
		public string ProcessorBrandString { get { return this._processorBrandString; } }
		public FeatureBits FeatureBits { get { return this._featureBits; } }
		public ProcessorInfo ProcessorInfo { get { return this._processorInfo; } }

		public LibCpuId() {
			this.FillRawData();
			this.DetectVendorId();
			this.DetectProcessorInfoAndFeatureBits();
			this.DetectExtendedProcessorInfoAndFeatureBits();
			this.DetectProcessorBrandString();
		}

		private void FillRawData() {
			CpuRegisters regs = cpuid(0);
			this._cpuidLevel = regs.eax;
			this._rawData.Add(0, regs);
			uint highestInput = regs.eax;

			for(uint i = 1; i <= highestInput; i++) {
				regs = cpuid(i);
				this._rawData.Add(i, regs);
			}

			// extended
			regs = cpuid(0x80000000);
			uint highestExtendedInput = regs.eax;
			if (highestExtendedInput > 0x80000000) {
				this._rawData.Add(0x80000000, regs);

				for(uint i = 0x80000001; i <= highestExtendedInput; i++) {
					regs = cpuid(i);
					this._rawData.Add(i, regs);
				}
			}
		}

		private void DetectVendorId() {
			CpuRegisters regs = cpuid(0);

			char[] vendorID = new char[12];
			vendorID[0] = (char)((regs.ebx) & 0xFF);
			vendorID[1] = (char)((regs.ebx >> 8) & 0xFF);
			vendorID[2] = (char)((regs.ebx >> 16) & 0xFF);
			vendorID[3] = (char)((regs.ebx >> 24));
			vendorID[4] = (char)((regs.edx) & 0xFF);
			vendorID[5] = (char)((regs.edx >> 8) & 0xFF);
			vendorID[6] = (char)((regs.edx >> 16) & 0xFF);
			vendorID[7] = (char)((regs.edx >> 24) & 0xFF);
			vendorID[8] = (char)((regs.ecx) & 0xFF);
			vendorID[9] = (char)((regs.ecx >> 8) & 0xFF);
			vendorID[10] = (char)((regs.ecx >> 16) & 0xFF);
			vendorID[11] = (char)((regs.ecx >> 24) & 0xFF);
			this._vendorId = new string(vendorID);
		}

		private void DetectProcessorInfoAndFeatureBits() {
			CpuRegisters regs = cpuid(1);

            this._processorInfo = new ProcessorInfo
            {
                Stepping = (UInt16)((regs.eax) & 0x0F),
                Model = (UInt16)((regs.eax >> 4) & 0x0F),
                Family = (UInt16)((regs.eax >> 8) & 0x0F),
                ProcessorType = (UInt16)((regs.eax >> 12) & 0x03),
                ExtendedModel = (UInt16)((regs.eax >> 16) & 0x0F),
                ExtendedFamily = (UInt16)((regs.eax >> 20) & 0xFF),
                Raw = regs.eax
            };

            this._featureBits = new FeatureBits
            {
                PrescottNewInstructions = ((regs.ecx & 0x01) > 0),
                PCLMULQDQ = ((regs.ecx & 0x02) > 0),
                DebugStore64Bit = ((regs.ecx & 0x04) > 0),
                MONITORAndMWAITInstructions = ((regs.ecx & 0x08) > 0),
                CPLQualifiedDebugStore = ((regs.ecx & 0x10) > 0),
                VirtualMachineExtensions = ((regs.ecx & 0x20) > 0),
                SaferModeExtensions = ((regs.ecx & 0x40) > 0),
                EnhancedSpeedStep = ((regs.ecx & 0x80) > 0),
                ThermalMonitor2 = ((regs.ecx & 0x100) > 0),
                SupplementalSSE3Instructions = ((regs.ecx & 0x200) > 0),
                ContextID = ((regs.ecx & 0x400) > 0),

                FusedMultiplyAdd = ((regs.ecx & 0x1000) > 0),
                CMPXCHG16BInstruction = ((regs.ecx & 0x2000) > 0),
                CanDisableSendingTaskPriorityMessages = ((regs.ecx & 0x4000) > 0),
                PerfmonAndDebugCapability = ((regs.ecx & 0x8000) > 0),

                ProcessContextIdentifiers = ((regs.ecx & 0x20000) > 0),
                DirectCacheAccessForDMAWrites = ((regs.ecx & 0x40000) > 0),
                SSE4_1Instructions = ((regs.ecx & 0x80000) > 0),
                SSE4_2Instructions = ((regs.ecx & 0x100000) > 0),
                x2APICSupport = ((regs.ecx & 0x200000) > 0),
                MOVBEInstruction = ((regs.ecx & 0x400000) > 0),
                POPCNTInstruction = ((regs.ecx & 0x800000) > 0),
                TSCDeadlineSupport = ((regs.ecx & 0x1000000) > 0),
                AESInstructionSet = ((regs.ecx & 0x2000000) > 0),
                XSAVE_XRESTOR_XSETBV_XGETBV_Support = ((regs.ecx & 0x4000000) > 0),
                XSAVEEnabledByOS = ((regs.ecx & 0x8000000) > 0),
                AdvancedVectorExtensions = ((regs.ecx & 0x10000000) > 0),
                CVT16InstructionSet = ((regs.ecx & 0x20000000) > 0),
                RDRANDSupport = ((regs.ecx & 0x40000000) > 0),
                RunningOnAHypervisor = ((regs.ecx & 0x80000000) > 0),

                Onboardx87FPU = ((regs.edx & 0x01) > 0),
                VirtualModeExtensions = ((regs.edx & 0x02) > 0),
                DebuggingExtensions = ((regs.edx & 0x04) > 0),
                PageSizeExtension = ((regs.edx & 0x08) > 0),
                TimeStampCounter = ((regs.edx & 0x10) > 0),
                ModelSpecificRegisters = ((regs.edx & 0x20) > 0),
                PhysicalAddressExtension = ((regs.edx & 0x40) > 0),
                MachineCheckException = ((regs.edx & 0x80) > 0),
                CMPXCHG8Instruction = ((regs.edx & 0x100) > 0),
                OnboardAPIC = ((regs.edx & 0x200) > 0),

                SYSENTERAndSYSEXITInstructions = ((regs.edx & 0x800) > 0),
                MemoryTypeRangeRegisters = ((regs.edx & 0x1000) > 0),
                PageGlobalEnableBitInCR4 = ((regs.edx & 0x2000) > 0),
                MachineCheckArchitecture = ((regs.edx & 0x4000) > 0),
                ConditionalMoveAndFCMOVInstructions = ((regs.edx & 0x8000) > 0),
                PageAttributeTable = ((regs.edx & 0x10000) > 0),
                PageSizeExtension36Bit = ((regs.edx & 0x20000) > 0),
                ProcessorSerialNumber = ((regs.edx & 0x40000) > 0),
                CLFLUSHInstruction = ((regs.edx & 0x80000) > 0),

                DebugStore = ((regs.edx & 0x200000) > 0),
                OnboardThermalControlMSRsForACPI = ((regs.edx & 0x400000) > 0),
                MMXInstructions = ((regs.edx & 0x800000) > 0),
                FXSAVE_FXRESTOR_Instructions = ((regs.edx & 0x1000000) > 0),
                SSEInstructions = ((regs.edx & 0x2000000) > 0),
                SSE2Instructions = ((regs.edx & 0x4000000) > 0),
                CPUCacheSupportsSelfSnoop = ((regs.edx & 0x8000000) > 0),
                HyperThreading = ((regs.edx & 0x10000000) > 0),
                ThermalMonitorAuomaticallyLimitsTemperature = ((regs.edx & 0x20000000) > 0),
                IA64ProcessorEmulatingx86 = ((regs.edx & 0x40000000) > 0),
                PendingBreakEnableWakeupSupport = ((regs.edx & 0x80000000) > 0)
            };
        }

		private void DetectExtendedProcessorInfoAndFeatureBits() {
			CpuRegisters regs = cpuid(0x80000001);

			this._featureBits.LAHF_SAHF_InLongMode = ((regs.ecx & 0x01) > 0);
			this._featureBits.HyperThreadingNotValid = ((regs.ecx & 0x02) > 0);
			this._featureBits.SecureVirtualMachine = ((regs.ecx & 0x04) > 0);
			this._featureBits.ExtendedAPICSpace = ((regs.ecx & 0x08) > 0);
			this._featureBits.CR8In32BitMode = ((regs.ecx & 0x10) > 0);
			this._featureBits.AdvancedBitManipulation = ((regs.ecx & 0x20) > 0);
			this._featureBits.SSE4a = ((regs.ecx & 0x40) > 0);
			this._featureBits.MisalignedSSEMode = ((regs.ecx & 0x80) > 0);
			this._featureBits.PREFETCHAndPREFETCHWInstructions = ((regs.ecx & 0x100) > 0);
			this._featureBits.OSVisibleWorkaround = ((regs.ecx & 0x200) > 0);
			this._featureBits.InstructionBasedSampling = ((regs.ecx & 0x400) > 0);
			this._featureBits.XOPInstructionSet = ((regs.ecx & 0x800) > 0);
			this._featureBits.SKINIT_STGI_Instructions = ((regs.ecx & 0x1000) > 0);
			this._featureBits.WatchdogTimer = ((regs.ecx & 0x2000) > 0);

			this._featureBits.LightweightProfiling = ((regs.ecx & 0x8000) > 0);
			this._featureBits.FourOperandsFusedMultiplyAdd = ((regs.ecx & 0x10000) > 0);
			this._featureBits.TranslationCacheExtension = ((regs.ecx & 0x20000) > 0);

			this._featureBits.NodeID_MSR = ((regs.ecx & 0x80000) > 0);

			this._featureBits.TrailingBitManipulation = ((regs.ecx & 0x200000) > 0);
			this._featureBits.TopologyExtensions = ((regs.ecx & 0x400000) > 0);
			this._featureBits.CorePerformanceCounterExtensions = ((regs.ecx & 0x800000) > 0);
			this._featureBits.NBPerformanceCounterExtensions = ((regs.ecx & 0x1000000) > 0);

			this._featureBits.SYSCALLAndSYSRETInstructions = ((regs.edx & 0x800) > 0);

			this._featureBits.MultiprocessorCapable = ((regs.edx & 0x80000) > 0);
			this._featureBits.NXBit = ((regs.edx & 0x100000) > 0);

			this._featureBits.ExtendedMMX = ((regs.edx & 0x400000) > 0);

			this._featureBits.FXSAVE_FXRSTOR_Instructions = ((regs.edx & 0x1000000) > 0);
			this._featureBits.FXSAVE_FXRSTOR_Optimizations = ((regs.edx & 0x2000000) > 0);
			this._featureBits.GibibytePages = ((regs.edx & 0x4000000) > 0);
			this._featureBits.RDTSCPInstruction = ((regs.edx & 0x8000000) > 0);

			this._featureBits.LongMode = ((regs.edx & 0x20000000) > 0);
			this._featureBits.Extended3DNow = ((regs.edx & 0x40000000) > 0);
			this._featureBits.AMD3DNow = ((regs.edx & 0x80000000) > 0);
		}

		private void DetectProcessorBrandString() {
			CpuRegisters regs = cpuid(0x80000000);
			char[] processorBrandString = new char[48];

			if (regs.eax < 0x80000004) { // feature is not supported
				return;
			}

			for(UInt16 i = 0; i < 3; i++) {
				int charIndexOffset = i * 16;

				regs = cpuid(0x80000002 + i);

				processorBrandString[charIndexOffset + 0] = (char)((regs.eax) & 0xFF);
				processorBrandString[charIndexOffset + 1] = (char)((regs.eax >> 8) & 0xFF);
				processorBrandString[charIndexOffset + 2] = (char)((regs.eax >> 16) & 0xFF);
				processorBrandString[charIndexOffset + 3] = (char)((regs.eax >> 24));
				processorBrandString[charIndexOffset + 4] = (char)((regs.ebx) & 0xFF);
				processorBrandString[charIndexOffset + 5] = (char)((regs.ebx >> 8) & 0xFF);
				processorBrandString[charIndexOffset + 6] = (char)((regs.ebx >> 16) & 0xFF);
				processorBrandString[charIndexOffset + 7] = (char)((regs.ebx >> 24));
				processorBrandString[charIndexOffset + 8] = (char)((regs.ecx) & 0xFF);
				processorBrandString[charIndexOffset + 9] = (char)((regs.ecx >> 8) & 0xFF);
				processorBrandString[charIndexOffset + 10] = (char)((regs.ecx >> 16) & 0xFF);
				processorBrandString[charIndexOffset + 11] = (char)((regs.ecx >> 24) & 0xFF);
				processorBrandString[charIndexOffset + 12] = (char)((regs.edx) & 0xFF);
				processorBrandString[charIndexOffset + 13] = (char)((regs.edx >> 8) & 0xFF);
				processorBrandString[charIndexOffset + 14] = (char)((regs.edx >> 16) & 0xFF);
				processorBrandString[charIndexOffset + 15] = (char)((regs.edx >> 24) & 0xFF);
			}

			this._processorBrandString = new string(processorBrandString);
		}

		public bool GetFeatureBit(FeatureBit featureBit) {
			bool result = false;

			switch(featureBit) {
				case FeatureBit.AdvancedBitManipulation:
					result = this._featureBits.AdvancedBitManipulation;
					break;
				
				case FeatureBit.AdvancedVectorExtensions:
					result = this._featureBits.AdvancedVectorExtensions;
					break;

				case FeatureBit.AESInstructionSet:
					result = this._featureBits.AESInstructionSet;
					break;

				case FeatureBit.AMD3DNow:
					result = this._featureBits.AMD3DNow;
					break;

				case FeatureBit.CanDisableSendingTaskPriorityMessages:
					result = this._featureBits.CanDisableSendingTaskPriorityMessages;
					break;

				case FeatureBit.CLFLUSHInstruction:
					result = this._featureBits.CLFLUSHInstruction;
					break;

				case FeatureBit.CMPXCHG16BInstruction:
					result = this._featureBits.CMPXCHG16BInstruction;
					break;

				case FeatureBit.CMPXCHG8Instruction:
					result = this._featureBits.CMPXCHG8Instruction;
					break;

				case FeatureBit.ConditionalMoveAndFCMOVInstructions:
					result = this._featureBits.ConditionalMoveAndFCMOVInstructions;
					break;

				case FeatureBit.ContextID:
					result = this._featureBits.ContextID;
					break;

				case FeatureBit.CorePerformanceCounterExtensions:
					result = this._featureBits.CorePerformanceCounterExtensions;
					break;

				case FeatureBit.CPLQualifiedDebugStore:
					result = this._featureBits.CPLQualifiedDebugStore;
					break;

				case FeatureBit.CPUCacheSupportsSelfSnoop:
					result = this._featureBits.CPUCacheSupportsSelfSnoop;
					break;

				case FeatureBit.CR8In32BitMode:
					result = this._featureBits.CR8In32BitMode;
					break;

				case FeatureBit.CVT16InstructionSet:
					result = this._featureBits.CVT16InstructionSet;
					break;

				case FeatureBit.DebuggingExtensions:
					result = this._featureBits.DebuggingExtensions;
					break;

				case FeatureBit.DebugStore:
					result = this._featureBits.DebugStore;
					break;

				case FeatureBit.DebugStore64Bit:
					result = this._featureBits.DebugStore64Bit;
					break;

				case FeatureBit.DirectCacheAccessForDMAWrites:
					result = this._featureBits.DirectCacheAccessForDMAWrites;
					break;

				case FeatureBit.EnhancedSpeedStep:
					result = this._featureBits.EnhancedSpeedStep;
					break;

				case FeatureBit.Extended3DNow:
					result = this._featureBits.Extended3DNow;
					break;

				case FeatureBit.ExtendedAPICSpace:
					result = this._featureBits.ExtendedAPICSpace;
					break;

				case FeatureBit.ExtendedMMX:
					result = this._featureBits.ExtendedMMX;
					break;

				case FeatureBit.FourOperandsFusedMultiplyAdd:
					result = this._featureBits.FourOperandsFusedMultiplyAdd;
					break;

				case FeatureBit.FusedMultiplyAdd:
					result = this._featureBits.FusedMultiplyAdd;
					break;

				case FeatureBit.FXSAVE_FXRESTOR_Instructions:
					result = this._featureBits.FXSAVE_FXRESTOR_Instructions;
					break;

				case FeatureBit.FXSAVE_FXRSTOR_Instructions:
					result = this._featureBits.FXSAVE_FXRSTOR_Instructions;
					break;

				case FeatureBit.FXSAVE_FXRSTOR_Optimizations:
					result = this._featureBits.FXSAVE_FXRSTOR_Optimizations;
					break;

				case FeatureBit.GibibytePages:
					result = this._featureBits.GibibytePages;
					break;

				case FeatureBit.HyperThreading:
					result = this._featureBits.HyperThreading;
					break;

				case FeatureBit.HyperThreadingNotValid:
					result = this._featureBits.HyperThreadingNotValid;
					break;

				case FeatureBit.IA64ProcessorEmulatingx86:
					result = this._featureBits.IA64ProcessorEmulatingx86;
					break;

				case FeatureBit.InstructionBasedSampling:
					result = this._featureBits.InstructionBasedSampling;
					break;

				case FeatureBit.LAHF_SAHF_InLongMode:
					result = this._featureBits.LAHF_SAHF_InLongMode;
					break;

				case FeatureBit.LightweightProfiling:
					result = this._featureBits.LightweightProfiling;
					break;

				case FeatureBit.LongMode:
					result = this._featureBits.LongMode;
					break;

				case FeatureBit.MachineCheckArchitecture:
					result = this._featureBits.MachineCheckArchitecture;
					break;

				case FeatureBit.MachineCheckException:
					result = this._featureBits.MachineCheckException;
					break;

				case FeatureBit.MemoryTypeRangeRegisters:
					result = this._featureBits.MemoryTypeRangeRegisters;
					break;

				case FeatureBit.MisalignedSSEMode:
					result = this._featureBits.MisalignedSSEMode;
					break;

				case FeatureBit.MMXInstructions:
					result = this._featureBits.MMXInstructions;
					break;

				case FeatureBit.ModelSpecificRegisters:
					result = this._featureBits.ModelSpecificRegisters;
					break;

				case FeatureBit.MONITORAndMWAITInstructions:
					result = this._featureBits.MONITORAndMWAITInstructions;
					break;

				case FeatureBit.MOVBEInstruction:
					result = this._featureBits.MOVBEInstruction;
					break;

				case FeatureBit.MultiprocessorCapable:
					result = this._featureBits.MultiprocessorCapable;
					break;

				case FeatureBit.NBPerformanceCounterExtensions:
					result = this._featureBits.NBPerformanceCounterExtensions;
					break;

				case FeatureBit.NodeID_MSR:
					result = this._featureBits.NodeID_MSR;
					break;

				case FeatureBit.NXBit:
					result = this._featureBits.NXBit;
					break;

				case FeatureBit.OnboardAPIC:
					result = this._featureBits.OnboardAPIC;
					break;

				case FeatureBit.OnboardThermalControlMSRsForACPI:
					result = this._featureBits.OnboardThermalControlMSRsForACPI;
					break;

				case FeatureBit.Onboardx87FPU:
					result = this._featureBits.Onboardx87FPU;
					break;

				case FeatureBit.OSVisibleWorkaround:
					result = this._featureBits.OSVisibleWorkaround;
					break;

				case FeatureBit.PageAttributeTable:
					result = this._featureBits.PageAttributeTable;
					break;

				case FeatureBit.PageGlobalEnableBitInCR4:
					result = this._featureBits.PageGlobalEnableBitInCR4;
					break;

				case FeatureBit.PageSizeExtension:
					result = this._featureBits.PageSizeExtension;
					break;

				case FeatureBit.PageSizeExtension36Bit:
					result = this._featureBits.PageSizeExtension36Bit;
					break;

				case FeatureBit.PCLMULQDQ:
					result = this._featureBits.PCLMULQDQ;
					break;

				case FeatureBit.PendingBreakEnableWakeupSupport:
					result = this._featureBits.PendingBreakEnableWakeupSupport;
					break;

				case FeatureBit.PerfmonAndDebugCapability:
					result = this._featureBits.PerfmonAndDebugCapability;
					break;

				case FeatureBit.PhysicalAddressExtension:
					result = this._featureBits.PhysicalAddressExtension;
					break;

				case FeatureBit.POPCNTInstruction:
					result = this._featureBits.POPCNTInstruction;
					break;

				case FeatureBit.PREFETCHAndPREFETCHWInstructions:
					result = this._featureBits.PREFETCHAndPREFETCHWInstructions;
					break;

				case FeatureBit.PrescottNewInstructions:
					result = this._featureBits.PrescottNewInstructions;
					break;

				case FeatureBit.ProcessContextIdentifiers:
					result = this._featureBits.ProcessContextIdentifiers;
					break;

				case FeatureBit.ProcessorSerialNumber:
					result = this._featureBits.ProcessorSerialNumber;
					break;

				case FeatureBit.RDRANDSupport:
					result = this._featureBits.RDRANDSupport;
					break;

				case FeatureBit.RDTSCPInstruction:
					result = this._featureBits.RDTSCPInstruction;
					break;

				case FeatureBit.RunningOnAHypervisor:
					result = this._featureBits.RunningOnAHypervisor;
					break;

				case FeatureBit.SaferModeExtensions:
					result = this._featureBits.SaferModeExtensions;
					break;

				case FeatureBit.SecureVirtualMachine:
					result = this._featureBits.SecureVirtualMachine;
					break;

				case FeatureBit.SKINIT_STGI_Instructions:
					result = this._featureBits.SKINIT_STGI_Instructions;
					break;

				case FeatureBit.SSE2Instructions:
					result = this._featureBits.SSE2Instructions;
					break;

				case FeatureBit.SSE4a:
					result = this._featureBits.SSE4a;
					break;

				case FeatureBit.SSE4_1Instructions:
					result = this._featureBits.SSE4_1Instructions;
					break;

				case FeatureBit.SSE4_2Instructions:
					result = this._featureBits.SSE4_2Instructions;
					break;

				case FeatureBit.SSEInstructions:
					result = this._featureBits.SSEInstructions;
					break;

				case FeatureBit.SupplementalSSE3Instructions:
					result = this._featureBits.SupplementalSSE3Instructions;
					break;

				case FeatureBit.SYSCALLAndSYSRETInstructions:
					result = this._featureBits.SYSCALLAndSYSRETInstructions;
					break;

				case FeatureBit.SYSENTERAndSYSEXITInstructions:
					result = this._featureBits.SYSENTERAndSYSEXITInstructions;
					break;

				case FeatureBit.ThermalMonitor2:
					result = this._featureBits.ThermalMonitor2;
					break;

				case FeatureBit.ThermalMonitorAuomaticallyLimitsTemperature:
					result = this._featureBits.ThermalMonitorAuomaticallyLimitsTemperature;
					break;

				case FeatureBit.TimeStampCounter:
					result = this._featureBits.TimeStampCounter;
					break;

				case FeatureBit.TopologyExtensions:
					result = this._featureBits.TopologyExtensions;
					break;

				case FeatureBit.TrailingBitManipulation:
					result = this._featureBits.TrailingBitManipulation;
					break;

				case FeatureBit.TranslationCacheExtension:
					result = this._featureBits.TranslationCacheExtension;
					break;

				case FeatureBit.TSCDeadlineSupport:
					result = this._featureBits.TSCDeadlineSupport;
					break;

				case FeatureBit.VirtualMachineExtensions:
					result = this._featureBits.VirtualMachineExtensions;
					break;

				case FeatureBit.VirtualModeExtensions:
					result = this._featureBits.VirtualModeExtensions;
					break;

				case FeatureBit.WatchdogTimer:
					result = this._featureBits.WatchdogTimer;
					break;

				case FeatureBit.x2APICSupport:
					result = this._featureBits.x2APICSupport;
					break;

				case FeatureBit.XOPInstructionSet:
					result = this._featureBits.XOPInstructionSet;
					break;

				case FeatureBit.XSAVEEnabledByOS:
					result = this._featureBits.XSAVEEnabledByOS;
					break;

				case FeatureBit.XSAVE_XRESTOR_XSETBV_XGETBV_Support:
					result = this._featureBits.XSAVE_XRESTOR_XSETBV_XGETBV_Support;
					break;
			}

			return result;
		}

		[LibraryImport("libcpuid.so", EntryPoint ="cpuid")]
		private static partial CpuRegisters cpuid(UInt32 input);
	}
}
