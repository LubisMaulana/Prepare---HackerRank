def kaprekar_numbers(p, q):
    result = []
    
    for i in range(p, q+1):
        pow_value = i * i
        str_pow = str(pow_value)
        mid = len(str_pow) // 2
        
        str_number1 = str_pow[:mid]
        number1 = int(str_number1) if str_number1 != "" else 0
        
        str_number2 = str_pow[mid:]
        number2 = int(str_number2) if str_number2 != "" else 0
        
        if number1 + number2 == i:
            result.append(i)

    if result:
        print(" ".join(map(str, result)))
    else:
        print("INVALID RANGE")


# Main function to handle input and call kaprekar_numbers
if __name__ == '__main__':
    p = int(input().strip())
    q = int(input().strip())
    
    kaprekar_numbers(p, q)
