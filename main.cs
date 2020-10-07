using System;

class MainClass {
  public static void Main (string[] args) {
    var x = 2;
		If(x < 7, () => {
			Console.WriteLine("x was less than 7");
		});

		If(x > 21, () => {
			Console.WriteLine("x was more than 21");
		});
		
		IfElse(true == false, () => {
			Console.WriteLine("Somehow true is false");
		}, () => {
			Console.WriteLine("True is not false");
		});
  }

	public static void If(bool statement, Action invoke) {
		for (;statement;) {
			invoke.Invoke();
			break;
		}
	}

	public static void IfElse(bool statement, Action invoke, Action invokeNot) {
		for (;statement;) {
			invoke.Invoke();
			return;
		}
		invokeNot.Invoke();
	}
}