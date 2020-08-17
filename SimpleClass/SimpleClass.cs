
namespace SimpleClass
{
    public class SimpleClass
    {
        public string SwitchExpression(int number) =>
            number switch
            {
                10 => "ten",
                20 => "twenty",
                _ => "unknown"
            };

        public string IfElse(bool condition)
        {
            if (condition)
            {
                return SwitchExpression(10);
            }
            else
            {
                return SwitchExpression(30);
            }
        }

    }
}
