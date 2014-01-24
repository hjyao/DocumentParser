Vistor pattern:
什么时候你会真正需要Vistor呢？
当你有很多运行在不同对象结构中的算法，并且没有比vistor更简洁的解决方案的时候，你就需要Vistor。

如果你不能通过一个通用的接口把互不相同的类变得类似，并且还有很多的外部聚集方法，重构到Vistor可能是最好的方案。

另一种需要Vistor的情况是，当你有很多外部聚集方法（external accumulation method）的时候，
典型情况下，这种方法使用Iterator【DP】模式，并通过对不同对象的类型转换来访问特殊信息，
如果对象类型转换不频繁的话，那么通过这种转换来访问他们的特殊接口是可以接受的；
但是，如果这种转换变得很频繁，就值得考虑更好地设计，除非你的互不相同的类有“异曲同工的类”的坏味道。

优点&缺点：
+对新的业务逻辑的扩展，有好的扩展性，开闭原则，IVisitor
+分离Document和相关Visitor的业务

-新的可访问类需要新的接收方法，每个Vistor中需要新的访问方法；
-会破坏访问类的封装性，“Tell，don't ask”

重构步骤：
1.在if中抽取Accept（documentPart）方法，将Text改成对应的documentPart类型，然后在调用端强转成对应的DocumentPart类型，rename params,对于强转的类型，可以提成参数再删掉之前的参数来做；依次应用之；
2.在accept（）中再次抽取方法，VisitTextNode（）；依次应用之；
3.将accept（）移到对应的DocumentPart类中(让其接收Document类，大家试试好方法)，将accept和visit手动public=>去掉static，再将accept搞成static，再non-static；
4.我们希望的是document.Accept(this),不要强转，怎么办呢？
将accept（）推到Document类中；做法：在PlainText的Accept（）方法上应用 pull member up，make method abstract；然后fix其他两个子类成override；修改Document，使其动态调用accept（）;只剩document.Accept(this); 
5.看这个Document类呢，包含了三个Visit方法，职责不够单一，单搞个HtmlVisitor会更好.
  在ToHtml（）中抽个参数出来，HtmlVisitor包含三个visit方法。
6.新需求来了=>>>>>ToMarkDown:
  对于plainText==  text；
  对于boldText== _text_;
  对于HyperLink== [text](url);
  势必要加个MarkDownVisitor，会有重复代码，更重要的呢，我们希望隔离Document类和Visitor访问端，
  Document并不需要知道那个Visitor.  抽个IVisitor，use base if possible.
7.加新的需求，先加个BoldText的测试，driven下.

