using System;
using DataStructures;
namespace Utility{
	public static class Utility<T>
	{
		public static void BubbleSort(ArrayList<T> input) 
		{
			if(input.Count < 1)
			{
				return;
			}
			bool isChanged = true;
			
			while(isChanged)
			{
				isChanged = false;
				for(int j =0; j < input.Count -1; ++j)
				{
					if (Convert.ToInt32(input.Index(j)) > Convert.ToInt32(input.Index(j+1))) {
						isChanged = true;
						//swap
						T temp = input.Index(j);
						input.Replace(j, input.Index(j + 1));
						input.Replace(j+1, temp);
					}
					
				}
			}
			return;
		}
	}
}

