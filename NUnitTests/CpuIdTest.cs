using System;
using NUnit.Framework;
using LibCpuId;

namespace LibCpuId {
	[TestFixture()]
	public class CpuIdTest {
		[Test()]
		public void CpuIdTestCase() {
			var libCpuId = new LibCpuId();
			Assert.IsNotEmpty(libCpuId.VendorId);
			Assert.IsNotEmpty(libCpuId.ProcessorBrandString);
		}
	}
}

