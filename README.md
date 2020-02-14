# The Task

Your bank is tired of its mainframe COBOL accounting software and they hired both of you for a greenfield project in - what a happy coincidence
your favorite programming language!
Your task is to show them that your TDD-fu and your new-age programming language can cope with good ole’ COBOL!

# Requirements

Write a class Account as the following

```c#
 public class BankAccount
    {
        public virtual void Deposit(int amount) {
            throw new NotImplementedException();
        }

        public virtual void Withdraw(int amount)
        {
            throw new NotImplementedException();
        }

        public virtual void PrintStatement()
        {
            throw new NotImplementedException();
        }
    }
```


An example statement would be:

```

Date             || Amount  || Balance

22/01/2016  || 300          || 1300

12/01/2016  || -500         || 1000

02/11/2015  || 1500        || 1500

```

