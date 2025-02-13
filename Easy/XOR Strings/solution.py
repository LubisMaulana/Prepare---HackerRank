def strings_xor(s, t):
    res = ""
    for i in range(len(s)):
        if s[i] == t[i]: #change "s[i] = t[i]" to "s[i] == t[i]"
            res += '0'; #change "res = '0'" to "res += '0'"
        else:
            res += '1'; #change "res = '1'" to "res += '1'"

    return res

s = input()
t = input()
print(strings_xor(s, t))
