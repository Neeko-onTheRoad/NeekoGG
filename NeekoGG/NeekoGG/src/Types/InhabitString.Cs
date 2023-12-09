namespace nk {
	public class InhabitString {
		
		private List<InhabitStringItem> elements;

		public InhabitString() {
			elements = new List<InhabitStringItem>();
		}

		public InhabitString(List<InhabitStringItem> _element) {
			elements = _element;
		}

		public InhabitString(params InhabitStringItem[] _elements) {
			elements = new List<InhabitStringItem>(_elements ?? Array.Empty<InhabitStringItem>());
		}

		public override string ToString() {
			string result = "";

			foreach(var i in elements ?? new List<InhabitStringItem>()) result += i.ToString();

			return result;
		}
	}
}
