using System;
using System.Collections.Generic;

public class GraphIsTree
{
	
    private int V; // No. of vertices 
    private List<int>[] adj; // Adjacency List 

    // Constructor 
    GraphIsTree(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }

    // Function to add an edge 
    // into the graph 
    void addEdge(int v, int w)
    {
        adj[v].Add(w);
        adj[w].Add(v);
    }

    // A recursive function that uses visited[]  
    // and parent to detect cycle in subgraph  
    // reachable from vertex v. 
    Boolean isCyclicUtil(int v, Boolean[] visited,
                         int parent)
    {
        // Mark the current node as visited 
        visited[v] = true;
        int i;

        // Recur for all the vertices  
        // adjacent to this vertex 
        foreach (int it in adj[v])
        {
            i = it;

            // If an adjacent is not visited,  
            // then recur for that adjacent 
            if (!visited[i])
            {
                if (isCyclicUtil(i, visited, v))
                    return true;
            }

            // If an adjacent is visited and  
            // not parent of current vertex, 
            // then there is a cycle. 
            else if (i != parent)
                return true;
        }
        return false;
    }

    // Returns true if the graph  
    // is a tree, else false. 
    Boolean isTree()
    {
        // Mark all the vertices as not visited  
        // and not part of recursion stack 
        Boolean[] visited = new Boolean[V];
        for (int i = 0; i < V; i++)
            visited[i] = false;

        // The call to isCyclicUtil serves  
        // multiple purposes. It returns true if  
        // graph reachable from vertex 0 is cyclcic.  
        // It also marks all vertices reachable from 0. 
        if (isCyclicUtil(0, visited, -1))
            return false;

        // If we find a vertex which is not reachable 
        // from 0 (not marked by isCyclicUtil(),  
        // then we return false 
        for (int u = 0; u < V; u++)
            if (!visited[u])
                return false;

        return true;
    }
}
