def check(arr):
    try:
        return arr.pop()
    except:
        return 0

def addTwoNumbers(l1, l2):
    result = []
    container = 0 
    digit = 0
    for i in range(len(l1)-1,-1,-1):
        container = check(l1)+ check(l2) + digit
        digit = 0
        if container < 10 :
            result.append(container)
        else:
            digit = 1
            result.append(container%10)
        container=0 
    if digit!= 0:
        result.append(digit)
    print(result)


list1 = [9,9,9,9,9,9,9] #your first list
list2 = [9,9,9,9] #your second list

addTwoNumbers(list1,list2)
    

