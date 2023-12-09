using SFML.Graphics;

namespace nk {
	public class InhabitStringItem {
		private object? value;

		public object? Value {
			get { return value; }
			set {
				try {
					if (value == null) {
						this.value = "";
						return;
					}

					else if (value is string)      this.value = value;
					else if (value is NamedSprite) this.value = value;
					else if (value is Color)       this.value = value;

					else throw new Exception();
				}
				catch(Exception _ex) {
					Console.WriteLine($"Wrong value on InhabitStringItems: {value?.GetType()} {_ex.StackTrace}");
				}
			}
		}

		public InhabitStringItem() {
			Value = null;
		}
		
		public InhabitStringItem(object? _value) {
			Value = _value;
		}

		public string ToElementString() {
			return $"{value?.GetType().Name}: {value?.ToString()}";
		}

		public override string ToString() {
			if (value is string) return (string)value;

			if (value is NamedSprite) {
				NamedSprite result = (NamedSprite)value;
				return $"[file: {result.Name}]";
			}

			else return "";
		}
	}
}
