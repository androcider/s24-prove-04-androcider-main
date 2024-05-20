using System.Collections;
using Microsoft.VisualBasic;

namespace prove_04;

/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("first", 3);
        priorityQueue.Enqueue("second", 2);
        priorityQueue.Enqueue("third", 3);

        Console.WriteLine(priorityQueue);
        priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: -1 added to queue.count, no console.writeline line, remove = from >= to just find the first one, 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");
        priorityQueue.Dequeue();
        // Defect(s) Found: remove return null

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}