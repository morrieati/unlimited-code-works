// ���� ifdef ���Ǵ���ʹ�� DLL �������򵥵�
// ��ı�׼�������� DLL �е������ļ��������������϶���� PRIORITYQUEUE_EXPORTS
// ���ű���ġ���ʹ�ô� DLL ��
// �κ�������Ŀ�ϲ�Ӧ����˷��š�������Դ�ļ��а������ļ����κ�������Ŀ���Ὣ
// PRIORITYQUEUE_API ������Ϊ�Ǵ� DLL ����ģ����� DLL ���ô˺궨���
// ������Ϊ�Ǳ������ġ�
#ifdef PRIORITYQUEUE_EXPORTS
#define PRIORITYQUEUE_API __declspec(dllexport)
#else
#define PRIORITYQUEUE_API __declspec(dllimport)
#endif

// �����Ǵ� PriorityQueue.dll ������
class PRIORITYQUEUE_API CPriorityQueue {
public:
	CPriorityQueue(void);
	// TODO:  �ڴ�������ķ�����
};

extern PRIORITYQUEUE_API int nPriorityQueue;

PRIORITYQUEUE_API int fnPriorityQueue(void);
