package main

import (
    "bufio"
    "fmt"
    "io"
    "os"
    "strings"
    "regexp"
)

// Complete the camelcase function below.
func camelcase(s string) int32 {
    r, _ := regexp.Compile("[A-Z]")
    caps := r.FindAllString(s, -1)
    
    return 1+int32(len(caps))
}

func main() {
    reader := bufio.NewReaderSize(os.Stdin, 1024 * 1024)

    stdout, err := os.Create(os.Getenv("OUTPUT_PATH"))
    checkError(err)

    defer stdout.Close()

    writer := bufio.NewWriterSize(stdout, 1024 * 1024)

    s := readLine(reader)

    result := camelcase(s)

    fmt.Fprintf(writer, "%d\n", result)

    writer.Flush()
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
