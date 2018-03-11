namespace Ftdi.Ftd2xx.Extensions
{
    internal static class ByteArrayExt
    {
        public static int? IndexOf(this byte[] array, byte search) {
            for(var i=0; i < array.Length; i++) {
                if (array[i] == search)
                {
                    return i;
                }
            }

            return null;
        }
    }
}
