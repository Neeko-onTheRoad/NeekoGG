namespace nk {
	public struct IntAndPercent {
		public int?     Int;
		public Percent? Percent;

		public IntAndPercent() {
			Int     = null;
			Percent = null;
		}

		public IntAndPercent(
			int     _int,
			Percent _percent
		) {
			Int     = _int;
			Percent = _percent;
		}

		public override string ToString() {
			return $"[IntAndPercent] Int: {Int}, Percent: {Percent}";
		}
	}
}
