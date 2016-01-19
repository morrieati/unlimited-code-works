// PriorityQueue.cpp : 定义 DLL 应用程序的导出函数。
// http://www.cnblogs.com/andyzeng/p/3702401.html 基于堆的优先级队列

#include "stdafx.h"
#include "PriorityQueue.h"


// 这是导出变量的一个示例
PRIORITYQUEUE_API int nPriorityQueue=0;

// 这是导出函数的一个示例。
PRIORITYQUEUE_API int fnPriorityQueue(void)
{
    return 42;
}

// 这是已导出类的构造函数。
// 有关类定义的信息，请参阅 PriorityQueue.h
CPriorityQueue::CPriorityQueue()
{
    return;
}
