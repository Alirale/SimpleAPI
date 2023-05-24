using Domain.Enums;

namespace Domain.Response
{
    public class Response<T>
    {
        internal Response(bool succeeded, IEnumerable<ResponseMessage> errors, T result)
        {
            Succeeded = succeeded;
            Errors = errors.ToArray();
            Result = result;
        }

        private Response(bool succeeded, IEnumerable<ResponseMessage> errors)
        {
            Succeeded = succeeded;
            Errors = errors.ToArray();
        }
        private Response(bool succeeded)
        {
            Succeeded = succeeded;
        }

        public T Result { get; set; }

        public bool Succeeded { get; set; }

        public ResponseMessage[] Errors { get; set; }


        public static Response<T> Success(T result)
        {
            return new Response<T>(true, new ResponseMessage[] { }, result);
        }

        public static Response<T> Failure(T result)
        {
            return new Response<T>(true, new ResponseMessage[] { }, result);
        }

        public static Response<T> Failure(IEnumerable<ResponseMessage> errors)
        {
            return new Response<T>(false, errors);
        }
    }
}