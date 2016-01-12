// CPlusPlusTestBed.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <sstream>
#include <string>
#include <bitset>

using  namespace std;

void ConvertToBinary(int n)
{
	if (n / 2 != 0) {
		ConvertToBinary(n / 2);
	}
	printf("%d\n", n % 2);
}

int _tmain(int argc, _TCHAR* argv[])
{
	std::string input;
	getline(cin, input);
	stringstream is;
	is << input;
	int n; 
	is >> n;

	for (int i = 0; i < n; i++)
	{
		getline(cin, input);
		int res = stoi(input);
		ConvertToBinary(res);
	}
	return 0;
}








