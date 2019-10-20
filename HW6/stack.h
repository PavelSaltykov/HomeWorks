#pragma once

// ������� �����
struct StackElement
{
	char value; // �������� �������� (������)
	StackElement *next; // ��������� �� ��������� �������
};

// ���������� ������ �������� �� ������� �����;
// ������� ��������� ��������� �� �������, ����������� ������.
void push(StackElement **top, char value);

// ������� ������� ������� � ������� ����� � ���������� ��� ��������;
// ��������� ��������� �� �������.
char pop(StackElement **top);

// �������� ����� �� �������;
// ������� ��������� ��������� �� ������� �����.
bool isEmpty(StackElement *top);