//*****************************************************************************
//** 3314. Construct the Minimum Bitwise Array I                    leetcode **
//*****************************************************************************
//** Bits whisper to bots in a lattice of light,                             **
//** Zeros yield softly when flipped into right,                             **
//** Malloc gives memory a place to belong,                                  **
//** And logic hums quietly, fixing the wrong.                               **
//*****************************************************************************

/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* minBitwiseArray(int* nums, int numsSize, int* returnSize) {
    int* retnum = (int*)malloc(sizeof(int) * numsSize);
    
    for(int i = 0; i < numsSize; i++)
    {
        retnum[i] = -1;
        if (nums[i] == 2)
        {
            continue;
        }
        for(int bitPosition = 1; bitPosition < 32; bitPosition++)
        {
            if(((nums[i] >> bitPosition) & 1) == 0)
            {
                int answer = nums[i] ^ (1 << (bitPosition - 1));
                retnum[i] = answer;
                break;
            }
        }
    }
    *returnSize = numsSize;
    return retnum;
}