﻿partial class Day01 : Day<int[][], int, int> {
	public Day01(int day_ref_int) : base(day_ref_int) {}

	private int SumTopCalories(int[][] input, int n = 1) {
		int[] max = new int[n];
		foreach (int[] calories in input) {
			int sum = calories.Sum();
			if (sum > max[0]) {
				max[0] = sum;
				int i = 0;
				while (i < n - 1 && max[i] > max[i + 1]) {
					(max[i], max[i + 1]) = (max[i + 1], max[i]);
					i++;
				}
			}
		}
		return max.Sum();
	}
}