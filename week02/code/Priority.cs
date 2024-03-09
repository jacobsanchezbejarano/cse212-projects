public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Expected Result: Alfred, Daniel, Jacob
        Console.WriteLine("Test 1");

        // Scenario: 

        priorityQueue.Enqueue("Jacob",3);
        priorityQueue.Enqueue("Daniel",5);
        priorityQueue.Enqueue("Alfred",6);

        var res = priorityQueue.Dequeue();
        Console.WriteLine(res);
        res = priorityQueue.Dequeue();
        Console.WriteLine(res);
        res = priorityQueue.Dequeue();
        Console.WriteLine(res);
        // Defect(s) Found: 

        // The method dequeue doesn't retire the max priority value from the List
        // The index didn't start at 0 in the for loop of dequeue


        Console.WriteLine("---------");

        // Test 2
        // Expected Result: Alfred, Jacob, Daniel
        Console.WriteLine("Test 2");

        priorityQueue = new PriorityQueue();

        // Scenario: 

        priorityQueue.Enqueue("Jacob",5);
        priorityQueue.Enqueue("Daniel",3);
        priorityQueue.Enqueue("Alfred",8);

        res = priorityQueue.Dequeue();
        Console.WriteLine(res);
        res = priorityQueue.Dequeue();
        Console.WriteLine(res);
        res = priorityQueue.Dequeue();
        Console.WriteLine(res);

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 3
        // Expected Result: Mama Coco, Alfred, Alejandro, Jacob, Daniel, Peter
        Console.WriteLine("Test 3");

        priorityQueue = new PriorityQueue();
        
        // Scenario: 
        priorityQueue.Enqueue("Jacob",5);
        priorityQueue.Enqueue("Daniel",3);
        priorityQueue.Enqueue("Alfred",8);
        priorityQueue.Enqueue("Alejandro",8);
        priorityQueue.Enqueue("Mama Coco",9);
        priorityQueue.Enqueue("Peter",2);

        res = priorityQueue.Dequeue();
        Console.WriteLine(res);
        res = priorityQueue.Dequeue();
        Console.WriteLine(res);
        res = priorityQueue.Dequeue();
        Console.WriteLine(res);
        res = priorityQueue.Dequeue();
        Console.WriteLine(res);
        res = priorityQueue.Dequeue();
        Console.WriteLine(res);
        res = priorityQueue.Dequeue();
        Console.WriteLine(res);



        // Defect(s) Found: 

        Console.WriteLine("---------");


        // Test 4
        // Scenario: Empty queue
        // Expected Result: The queue is empty.
        Console.WriteLine("Test 4");

        priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();

        Console.WriteLine("---------");
        

        // Add more Test Cases As Needed Below
    }
}