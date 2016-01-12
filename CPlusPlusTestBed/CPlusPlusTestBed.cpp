// CPlusPlusTestBed.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <sstream>

using  namespace std;

int find_gcd(int x, int y){
	//Write base condition
	if (x != 0 && y != 0)return find_gcd(y, x%y);
	else return max(x,y);
}

int _tmain(int argc, _TCHAR* argv[])
{
	std::string s;
	getline(cin, s);
	stringstream is;
	is << s;
	int x, y; 
	is >> x >> y;
	
	int gcd = find_gcd(x, y);
	cout << gcd;
	return 0;
}








