using System;
using NUnit.Framework;
using LibCpuId;

namespace LibCpuId {
	[TestFixture()]
	public class CpuIdTest {
		[Test()]
		public void CpuIdTestCase() {
			var libCpuId = new LibCpuId();
			Assert.That(libCpuId.VendorId != string.Empty);
			Assert.That(libCpuId.ProcessorBrandString != string.Empty);
		}
	}
}

