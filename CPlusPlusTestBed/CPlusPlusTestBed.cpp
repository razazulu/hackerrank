#include "stdafx.h"
#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <sstream>
#include <string>
#include <bitset>
using namespace std;

class Node
{
public:
	int data;
	Node *next;
	Node(int d){
		data = d;
		next = NULL;
	}
};

class Solution{
public:
	Node* insert(Node *head, int data)
	{
		Node *n = new Node(data);

		if (head == NULL)return n;

		Node *current = head;

		while (current->next != NULL)
		{
			current = current->next;
		}

		current->next = n;

		return head;
	}
	
	void display(Node *head)
	{
		Node *start = head;
		while (start)
		{
			cout << start->data << " ";
			start = start->next;
		}
	}
};

int _tmain(int argc, _TCHAR* argv[])
{
	Node* head = NULL;
	Solution mylist;
	int T, data;
	cin >> T;
	while (T-->0){
		cin >> data;
		head = mylist.insert(head, data);
	}
	mylist.display(head);
	return 0;
}









