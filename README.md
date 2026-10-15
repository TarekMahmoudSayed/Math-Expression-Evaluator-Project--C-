# Math Expression Evaluator (C#)

أول مشروع تدريبي ليا بلغة C#، عبارة عن Console Application بياخد Mathematical Expression كـ نص (Text) من المستخدم ويحسبه. اتبنى وأنا بتعلم أساسيات اللغة: OOP، منطق الـ Parsing، وتقسيم المشروع لـ Classes منفصلة بدل ما يكون كله في ملف واحد.

## Features

- عمليات حسابية أساسية: Addition (`+`), Subtraction (`-`), Multiplication (`*`), Division (`/`), Modulus (`%`), Power (`^` أو `pow`).
- دوال مثلثية (المدخل بالـ Degrees): `sin`, `cos`, `tan`.

## Example Usage

```
Please Enter expression To Evaluate: 5 + 3
5 + 3 = 8

Please Enter expression To Evaluate: 10 % 3
10 % 3 = 1

Please Enter expression To Evaluate: 2 ^ 5
2 ^ 5 = 32

Please Enter expression To Evaluate: sin 30
sin 30 = 0.5
```

## Project Structure

```
MathExpressionEvaluator/
├── Program.cs                 # Entry point
├── ExpressionEvaluator.cs     # بيحسب الـ Expression بعد ما يتحلل
├── ExpressionParser.cs        # بيحلل النص المدخل ويحوله لـ Expression
├── MathExpression.cs          # الـ Model اللي بيمثل الـ Expression
├── MathOperation.cs           # الـ Enum بتاع أنواع العمليات المدعومة
└── MathExpressionEvaluatorProject.csproj
```

## Built With

C# / .NET — Console Application من غير أي External Dependencies.

## How to Run

```bash
git clone https://github.com/TarekMahmoudSayed/Math-Expression-Evaluator-Project--C-.git
cd Math-Expression-Evaluator-Project--C-
dotnet run
```

## Known Limitations

المشروع حالياً بيدعم Operation واحدة بس بين رقمين (Operands) في المرة الواحدة، زي `5 + 3` أو `sin 30`. لسه مبيدعمش:

- تعبيرات مركبة فيها أكتر من Operator في نفس الوقت (زي `3 + 4 * 2`).
- Parentheses أو Operator Precedence.
- Error Handling للمدخلات الغلط.

## Author

**Tarek Mahmoud Sayed**
- GitHub: [TarekMahmoudSayed](https://github.com/TarekMahmoudSayed)
- LinkedIn: [Tarek Mahmoud](https://www.linkedin.com/in/tarek-mahmoud-0795b73b5)
