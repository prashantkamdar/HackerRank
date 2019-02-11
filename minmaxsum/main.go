package main

import (
    "bufio"
    "fmt"
    "io"
    "os"
    "strconv"
    "strings"
	"sort"
)

// Complete the miniMaxSum function below.
func miniMaxSum(arr []int64) {
	sort.Slice(arr, func(i, j int) bool { return arr[i] < arr[j] })
	
	var minSum int64
	var maxSum int64
	
	minSum=arr[0]+arr[1]+arr[2]+arr[3]
	maxSum=arr[1]+arr[2]+arr[3]+arr[4]
	
	fmt.Printf("%d %d", minSum, maxSum)
}

func main() {
    reader := bufio.NewReaderSize(os.Stdin, 1024 * 1024)

    arrTemp := strings.Split(readLine(reader), " ")

    var arr []int64

    for i := 0; i < 5; i++ {
        arrItemTemp, err := strconv.ParseInt(arrTemp[i], 10, 64)
        checkError(err)
        arrItem := int64(arrItemTemp)
        arr = append(arr, arrItem)
    }

    miniMaxSum(arr)
}

func readLine(reader *bufio.Reader) string {
    str, _, err := reader.ReadLine()
    if err == io.EOF {
        return ""
    }

    return strings.TrimRight(string(str), "\r\n")
}

func checkError(err error) {
    if err != nil {
        panic(err)
    }
}
