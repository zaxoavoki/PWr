# Zadanie 4


def moving_average(arr):
    return [sum([arr[i + j] for j in range(arr[0])]) / arr[0] for i in
            range(1, len(arr) - arr[0] + 1)]


if __name__ == '__main__':
    print(moving_average([5, 1, 2, 3, 4, 5, 6, 7]))
