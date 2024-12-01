package main

import (
	"fmt"
	"time"
)

func executionTime(name string, f func()) {
	start := time.Now()
	f()
	elapsed := time.Since(start)
	fmt.Printf("%s took %s\n", name, elapsed)
}
