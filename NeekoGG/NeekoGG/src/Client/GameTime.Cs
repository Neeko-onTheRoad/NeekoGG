namespace nk.Client {
	public class GameTime {
		
		private float deltaTime = 0f;
		private float timeScale = 1f;

		public float TimeScale {
			get { return timeScale; }
			set { timeScale = value; }
		}

		public float DeltaTime {
			get { return deltaTime * timeScale; }
			set { deltaTime = value; }
		}

		public float DeltaTimeUnscaled {
			get { return deltaTime; }
		}

		public float TotalTimeElapsed {
			get; private set;
		}

		public GameTime() { }

		public void Update(float _deltaTime, float _totlaTimeElapsed) {
			deltaTime        = _deltaTime;
			TotalTimeElapsed = _totlaTimeElapsed;
		}

	}
}
