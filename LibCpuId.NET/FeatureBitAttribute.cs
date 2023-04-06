using System;

namespace LibCpuId {
	[AttributeUsage(AttributeTargets.All)]
	public class FeatureBitAttribute : Attribute {
		private readonly string _abbreviation = String.Empty;
		private readonly string _longName = String.Empty;

		public string Abbreviation { get { return this._abbreviation; } }
		public string LongName { get { return this._longName; } }

		public FeatureBitAttribute(string abbreviation, string longName) {
			this._abbreviation = abbreviation;
			this._longName = longName;
		}
	}
}

