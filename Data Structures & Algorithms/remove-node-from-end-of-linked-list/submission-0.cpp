/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */

class Solution {
public:
    ListNode* removeNthFromEnd(ListNode* head, int n) {
        

        std::vector<ListNode*> nodes;

        ListNode* current = head;
        while (current != nullptr)
        {
            nodes.push_back(current);
            current = current->next;
            
        }

        int sz = static_cast<int>(nodes.size());


        if(n == sz) return head->next;
        if(n == 1) {
            (nodes[sz - 2])->next = nullptr;
            return head;
        }

        ListNode* prev = nodes[sz - n - 1];
        ListNode* next = nodes[sz - n + 1];
        prev->next = next;

        return head;

    }
};
