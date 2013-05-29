using System;
using NUnit.Framework;
using libcpuid;

namespace libcpuid {
	[TestFixture()]
	public class CpuIdTest {
		[Test()]
		public void CpuIdTestCase() {
			LibCpuId libCpuId = new LibCpuId();
			Assert.IsNotEmpty(libCpuId.VendorId);
			Assert.IsNotEmpty(libCpuId.ProcessorBrandString);
		}
	}
}

