int[] arr = { 10, 4, 6, 7, 8, 6, 0, 0, 0, 0 };
int[] arr1 = themPhanTuKhoiMang(arr, 6,1);
// ham them phan tu trong mang
static int[] themPhanTuKhoiMang(int[] arr, int x, int y)
{
    for (int i = arr.Length-1; i >=x; i--){
        arr[i] = arr[i-1];
    }
    arr[x-1]=y;
    return arr;
}
Console.WriteLine(string.Join(",",arr1));
