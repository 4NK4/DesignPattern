///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

1、开闭原则（Open Close Principle）对扩展开放，对修改关闭。

2、里氏代换原则（Liskov Substitution Principle）任何基类可以出现的地方，子类一定可以出现

3、依赖倒转原则（Dependence Inversion Principle）针对接口编程

4、接口隔离原则（Interface Segregation Principle）使用多个隔离的接口，比使用单个接口要好

5、迪米特法则（Demeter Principle）一个对象尽量少的知道其它对象

6、合成复用原则（Composite Reuse Principle）尽量使用合成/聚合的方式，而不是使用继承。



创建型模式(Creational pattern):使得创建的对象更受控制与选择
	工厂模式（Factory Pattern）
	抽象工厂模式（Abstract Factory Pattern）
	单例模式（Singleton Pattern）
	建造者模式（Builder Pattern）
	原型模式（Prototype Pattern）

结构型模式(Structural Pattern):关注类和对象的组合以获得新功能
	适配器模式（Adapter Pattern）
	桥接模式（Bridge Pattern）
	过滤器模式（Filter、Criteria Pattern）
	组合模式（Composite Pattern）
	装饰器模式（Decorator Pattern）
	外观模式（Facade Pattern）
	享元模式（Flyweight Pattern）
	代理模式（Proxy Pattern）
	
行为型模式(Behavioral pattern):关注对象之间的通信。
	责任链模式（Chain of Responsibility Pattern）
	命令模式（Command Pattern）
	解释器模式（Interpreter Pattern）
	迭代器模式（Iterator Pattern）
	中介者模式（Mediator Pattern）
	备忘录模式（Memento Pattern）
	观察者模式（Observer Pattern）
	状态模式（State Pattern）
	空对象模式（Null Object Pattern）
	策略模式（Strategy Pattern）
	模板模式（Template Pattern）
	访问者模式（Visitor Pattern）


	

虚线箭头指向依赖(必要条件)；A依赖B 则A指向B
实线箭头指向关联(充分条件)；A知道B,则A指向B

虚线三角指向接口(交集)；
实线三角指向父类(并集)；


(整体与部分)
空心菱形能分离而独立存在，是聚合；A个体与B群的关系 B指向A
实心菱形精密关联不可分，是组合；A个体与B部分,A指向B

2030年IT行业技术趋向
	云计算
	人工智能
		增强现实(旅游业 零售业,娱乐业 ---目前反应太冷淡)
		智能交通(交通信号灯,智能物流机器人的路线规划....)
		工业智联

