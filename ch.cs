using System;


class Solution {
    public int solution(int[] A) {
        Array.Sort(A);     
        int ret = 1; 
        if(A[A.Length-1] < 1) return ret;
        if(A[0]>1) return ret;
        for (int i = 0; i < A.Length; i++){
            if(A[i] == ret){
                ret++;
                if(i+1 < A.Length){
                    if(A[i+1]> ret) return ret;
                } 
            }
        }   
        return ret;    
    }
}