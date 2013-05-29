using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace libcpuid {
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
	}

	public struct FeatureBits {
		// ecx Register
		public bool PrescottNewInstructions;
		public bool PCLMULQDQ;
		public bool DebugStore64Bit;
		public bool MONITORAndMWAITInstructions;
		public bool CPLQualifiedDebugStore;
		public bool VirtualMachineExtensions;
		public bool SaferModeExtensions;
		public bool EnhancedSpeedStep;
		public bool ThermalMonitor2;
		public bool SupplementalSSE3Instructions;
		public bool ContextID;
		public bool FusedMultiplyAdd;
		public bool CMPXCHG16BInstruction;
		public bool CanDisableSendingTaskPriorityMessages;
		public bool PerfmonAndDebugCapability;
		public bool ProcessContextIdentifiers;
		public bool DirectCacheAccessForDMAWrites;
		public bool SSE4_1Instructions;
		public bool SSE4_2Instructions;
		public bool x2APICSupport;
		public bool MOVBEInstruction;
		public bool POPCNTInstruction;
		public bool TSCDeadlineSupport;
		public bool AESInstructionSet;
		public bool XSAVE_XRESTOR_XSETBV_XGETBV_Support;
		public bool XSAVEEnabledByOS;
		public bool AdvancedVectorExtensions;
		public bool CVT16InstructionSet;
		public bool RDRANDSupport;
		public bool RunningOnAHypervisor;

		// edx Register
		public bool Onboardx87FPU;
		public bool VirtualModeExtensions;
		public bool DebuggingExtensions;
		public bool PageSizeExtension;
		public bool TimeStampCounter;
		public bool ModelSpecificRegisters;
		public bool PhysicalAddressExtension;
		public bool MachineCheckException;
		public bool CMPXCHG8Instruction;
		public bool OnboardAPIC;
		public bool SYSENTERAndSYSEXITInstructions;
		public bool MemoryTypeRangeRegisters;
		public bool PageGlobalEnableBitInCR4;
		public bool MachineCheckArchitecture;
		public bool ConditionalMoveAndFCMOVInstructions;
		public bool PageAttributeTable;
		public bool PageSizeExtension36Bit;
		public bool ProcessorSerialNumber;
		public bool CLFLUSHInstruction;
		public bool DebugStore;
		public bool OnboardThermalControlMSRsForACPI;
		public bool MMXInstructions;
		public bool FXSAVE_FXRESTOR_Instructions;
		public bool SSEInstructions;
		public bool SSE2Instructions;
		public bool CPUCacheSupportsSelfSnoop;
		public bool HyperThreading;
		public bool ThermalMonitorAuomaticallyLimitsTemperature;
		public bool IA64ProcessorEmulatingx86;
		public bool PendingBreakEnableWakeupSupport;

		// extended features

		// ecx Register
		public bool LAHF_SAHF_InLongMode;
		public bool HyperThreadingNotValid;
		public bool SecureVirtualMachine;
		public bool ExtendedAPICSpace;
		public bool CR8In32BitMode;
		public bool AdvancedBitManipulation;
		public bool SSE4a;
		public bool MisalignedSSEMode;
		public bool PREFETCHAndPREFETCHWInstructions;
		public bool OSVisibleWorkaround;
		public bool InstructionBasedSampling;
		public bool XOPInstructionSet;
		public bool SKINIT_STGI_Instructions;
		public bool WatchdogTimer;
		public bool LightweightProfiling;
		public bool FourOperandsFusedMultiplyAdd;
		public bool TranslationCacheExtension;
		public bool NodeID_MSR;
		public bool TrailingBitManipulation;
		public bool TopologyExtensions;
		public bool CorePerformanceCounterExtensions;
		public bool NBPerformanceCounterExtensions;

		// edx Register
		public bool SYSCALLAndSYSRETInstructions;
		public bool MultiprocessorCapable;
		public bool NXBit;
		public bool ExtendedMMX;
		public bool FXSAVE_FXRSTOR_Instructions;
		public bool FXSAVE_FXRSTOR_Optimizations;
		public bool GibibytePages;
		public bool RDTSCPInstruction;
		public bool LongMode;
		public bool Extended3DNow;
		public bool AMD3DNow;
	}

	public class LibCpuId {
		private string _vendorId = String.Empty;
		private string _processorBrandString = String.Empty;
		private FeatureBits _featureBits;
		private ProcessorInfo _processorInfo;

		public string VendorId { get { return this._vendorId; } }
		public string ProcessorBrandString { get { return this._processorBrandString; } }
		public FeatureBits FeatureBits { get { return this._featureBits; } }
		public ProcessorInfo ProcessorInfo { get { return this._processorInfo; } }

		public LibCpuId() {
			this.DetectVendorId();
			this.DetectProcessorInfoAndFeatureBits();
			this.DetectExtendedProcessorInfoAndFeatureBits();
			this.DetectProcessorBrandString();
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

			this._processorInfo = new ProcessorInfo();
			this._processorInfo.Stepping = (UInt16)((regs.eax) & 0x0F);
			this._processorInfo.Model = (UInt16)((regs.eax >> 4) & 0x0F);
			this._processorInfo.Family = (UInt16)((regs.eax >> 8) & 0x0F);
			this._processorInfo.ProcessorType = (UInt16)((regs.eax >> 12) & 0x03);
			this._processorInfo.ExtendedModel = (UInt16)((regs.eax >> 16) & 0x0F);
			this._processorInfo.ExtendedFamily = (UInt16)((regs.eax >> 20) & 0xFF);

			this._featureBits = new FeatureBits();
			this._featureBits.PrescottNewInstructions = ((regs.ecx & 0x01) > 0);
			this._featureBits.PCLMULQDQ = ((regs.ecx & 0x02) > 0);
			this._featureBits.DebugStore64Bit = ((regs.ecx & 0x04) > 0);
			this._featureBits.MONITORAndMWAITInstructions = ((regs.ecx & 0x08) > 0);
			this._featureBits.CPLQualifiedDebugStore = ((regs.ecx & 0x10) > 0);
			this._featureBits.VirtualMachineExtensions = ((regs.ecx & 0x20) > 0);
			this._featureBits.SaferModeExtensions = ((regs.ecx & 0x40) > 0);
			this._featureBits.EnhancedSpeedStep = ((regs.ecx & 0x80) > 0);
			this._featureBits.ThermalMonitor2 = ((regs.ecx & 0x100) > 0);
			this._featureBits.SupplementalSSE3Instructions = ((regs.ecx & 0x200) > 0);
			this._featureBits.ContextID = ((regs.ecx & 0x400) > 0);

			this._featureBits.FusedMultiplyAdd = ((regs.ecx & 0x1000) > 0);
			this._featureBits.CMPXCHG16BInstruction = ((regs.ecx & 0x2000) > 0);
			this._featureBits.CanDisableSendingTaskPriorityMessages = ((regs.ecx & 0x4000) > 0);
			this._featureBits.PerfmonAndDebugCapability = ((regs.ecx & 0x8000) > 0);

			this._featureBits.ProcessContextIdentifiers = ((regs.ecx & 0x20000) > 0);
			this._featureBits.DirectCacheAccessForDMAWrites = ((regs.ecx & 0x40000) > 0);
			this._featureBits.SSE4_1Instructions = ((regs.ecx & 0x80000) > 0);
			this._featureBits.SSE4_2Instructions = ((regs.ecx & 0x100000) > 0);
			this._featureBits.x2APICSupport = ((regs.ecx & 0x200000) > 0);
			this._featureBits.MOVBEInstruction = ((regs.ecx & 0x400000) > 0);
			this._featureBits.POPCNTInstruction = ((regs.ecx & 0x800000) > 0);
			this._featureBits.TSCDeadlineSupport = ((regs.ecx & 0x1000000) > 0);
			this._featureBits.AESInstructionSet = ((regs.ecx & 0x2000000) > 0);
			this._featureBits.XSAVE_XRESTOR_XSETBV_XGETBV_Support = ((regs.ecx & 0x4000000) > 0);
			this._featureBits.XSAVEEnabledByOS = ((regs.ecx & 0x8000000) > 0);
			this._featureBits.AdvancedVectorExtensions = ((regs.ecx & 0x10000000) > 0);
			this._featureBits.CVT16InstructionSet = ((regs.ecx & 0x20000000) > 0);
			this._featureBits.RDRANDSupport = ((regs.ecx & 0x40000000) > 0);
			this._featureBits.RunningOnAHypervisor = ((regs.ecx & 0x80000000) > 0);

			this._featureBits.Onboardx87FPU = ((regs.edx & 0x01) > 0);
			this._featureBits.VirtualModeExtensions = ((regs.edx & 0x02) > 0);
			this._featureBits.DebuggingExtensions = ((regs.edx & 0x04) > 0);
			this._featureBits.PageSizeExtension = ((regs.edx & 0x08) > 0);
			this._featureBits.TimeStampCounter = ((regs.edx & 0x10) > 0);
			this._featureBits.ModelSpecificRegisters = ((regs.edx & 0x20) > 0);
			this._featureBits.PhysicalAddressExtension = ((regs.edx & 0x40) > 0);
			this._featureBits.MachineCheckException = ((regs.edx & 0x80) > 0);
			this._featureBits.CMPXCHG8Instruction = ((regs.edx & 0x100) > 0);
			this._featureBits.OnboardAPIC = ((regs.edx & 0x200) > 0);

			this._featureBits.SYSENTERAndSYSEXITInstructions = ((regs.edx & 0x800) > 0);
			this._featureBits.MemoryTypeRangeRegisters = ((regs.edx & 0x1000) > 0);
			this._featureBits.PageGlobalEnableBitInCR4 = ((regs.edx & 0x2000) > 0);
			this._featureBits.MachineCheckArchitecture = ((regs.edx & 0x4000) > 0);
			this._featureBits.ConditionalMoveAndFCMOVInstructions = ((regs.edx & 0x8000) > 0);
			this._featureBits.PageAttributeTable = ((regs.edx & 0x10000) > 0);
			this._featureBits.PageSizeExtension36Bit = ((regs.edx & 0x20000) > 0);
			this._featureBits.ProcessorSerialNumber = ((regs.edx & 0x40000) > 0);
			this._featureBits.CLFLUSHInstruction = ((regs.edx & 0x80000) > 0);

			this._featureBits.DebugStore = ((regs.edx & 0x200000) > 0);
			this._featureBits.OnboardThermalControlMSRsForACPI = ((regs.edx & 0x400000) > 0);
			this._featureBits.MMXInstructions = ((regs.edx & 0x800000) > 0);
			this._featureBits.FXSAVE_FXRESTOR_Instructions = ((regs.edx & 0x1000000) > 0);
			this._featureBits.SSEInstructions = ((regs.edx & 0x2000000) > 0);
			this._featureBits.SSE2Instructions = ((regs.edx & 0x4000000) > 0);
			this._featureBits.CPUCacheSupportsSelfSnoop = ((regs.edx & 0x8000000) > 0);
			this._featureBits.HyperThreading = ((regs.edx & 0x10000000) > 0);
			this._featureBits.ThermalMonitorAuomaticallyLimitsTemperature = ((regs.edx & 0x20000000) > 0);
			this._featureBits.IA64ProcessorEmulatingx86 = ((regs.edx & 0x40000000) > 0);
			this._featureBits.PendingBreakEnableWakeupSupport = ((regs.edx & 0x80000000) > 0);
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

		[DllImport("libcpuid.so", EntryPoint="cpuid")]
		private static extern CpuRegisters cpuid(UInt32 input);
	}
}
