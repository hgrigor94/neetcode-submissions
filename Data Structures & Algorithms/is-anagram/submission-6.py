from collections import Counter
class Solution:
    def isAnagram(self, s: str, t: str) -> bool:

        if len(s) != len(t):
            return False

        c = Counter(s)
        for ch in t:
            if not c[ch]:
                return False
            c[ch] -= 1
        else:
            return True

