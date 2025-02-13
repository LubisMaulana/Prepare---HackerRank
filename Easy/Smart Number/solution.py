import math

def is_smart_number(num):
    val = int(math.sqrt(num))
    if num / val == val and num % val == 0: #change "num / val == 1" to "num / val == val and num % val == 0"
        return True
    return False

for _ in range(int(input())):
    num = int(input())
    ans = is_smart_number(num)
    if ans:
        print("YES")
    else:
        print("NO")
