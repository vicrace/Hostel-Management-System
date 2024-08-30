using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Defaultt
{
    public class LengthException:Exception//to handle exception the length of the string 
    {
        public LengthException(string errorInfo)
        : base(String.Format("Invalid Input.\nReason: The length of input must be {0} characters.",errorInfo))
        {

        }

        public LengthException()
        
        {

        }
    }

    public class NoneExistException : Exception//to handle exception for the record exist 
    {
        public NoneExistException(string errorInfo)
        : base(String.Format("Invalid Input.\nReason: {0} does not exists.", errorInfo))
        {

        }

        public NoneExistException()

        {

        }
    }

    public class LetterOnlyException : Exception//to handle exception for the string that contain letter only
    {
        public LetterOnlyException(string errorInfo)
        :base(String.Format("Invalid Input: {0}\nReason: Input must consists of only letters.",errorInfo))
        {

        }

        public LetterOnlyException()
        {

        } 
    }

    public class NumberOnlyException : Exception//to handle exception for the string that contain number only
    {
        public NumberOnlyException(string errorInfo)
            : base(String.Format("Invalid Input: {0}\nReason: Input must consists of only numbers.", errorInfo))
        {

        }
        public NumberOnlyException()
        {

        }
    }

    public class NullException : Exception//to handle exception for the string that null value
    {
        public NullException()
            : base(String.Format("Input is invalid.\nReason: Input must not be empty."))
        {

        }
    }

    public class DuplicationException : Exception//to handle exception for the string is the same or non unique
    {
        public DuplicationException(string errorInfo)
            : base(String.Format("Invalid Input:{0}\nReason: There is duplication of the input.", errorInfo))
        {

        }

        public DuplicationException()
            : base(String.Format("Invalid Input.\nReason: There is duplication of the input."))
        {

        }
    }

    public class NoneSelectionException : Exception//to handle exception for record selection 
    {
        public NoneSelectionException()
            :base(String.Format("Invalid Operation.\nReason: No item is selected."))
        {

        }
    }

    public class NoneSearchException : Exception//to handle exception for search field if no item is being entered to search
    {
        public NoneSearchException()
            : base(String.Format("Invalid Operation.\nReason: No item is searched."))
        {

        }
    }


    public class SpaceException : Exception//to handle exception for the string that contain spacing
    {
        public SpaceException()
            : base(String.Format("Invalid Input.\nReason: Input contains space between characters."))
        {

        }

    }
}
