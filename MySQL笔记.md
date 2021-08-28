## MySQL

#### 登录:

- 把mysql.exe拖入cmd窗口 +空格+-u(账户)+空格+-p(密码)
- 在开始页面找到MySQL x.x Command Line Client 运行输入密码即可

#### 常用语句:

- quit - 退出数据库
- help; - 查看数据库帮助
- show databases; - 查看数据库
- create database XXX; - 创建数据库
- dorp databases XXX; - 删除数据库
- use XXX;  - 使用这个数据库
- show tables; - 打开使用中数据库的表

#### MySQL语句

- create table testtable( id int auto_increment,username varchar(30),password varchar(30),primary key(id)); - 创建表

  ​                    表名      名称 类型 自动补齐       名称           类型(最多)     名称         类型(最多)  指定主键(主键名)         

- drop table  testtable; - 删除表

  ​                    表名

- desc testtable; - 查询表结构

  ​          表名

- insert into testtable(username,password) values('Tang','Ze'); - 插入表

  ​                 表名                插入名称                         插入值

- select * from testtable; - 查询表

  (从哪里查*代表全部) 表名

- update testtable set username='001'; - 修改表数据(修改全部 无限制)

  ​               表名             名称        值 后没有限制将修改全部

- update testtable set username='Tang' where id=1; - 修改表数据(限制)

  ​               表名             名称            值    限制 id为1的将被修改

- update testtable set username='TangZe',password='554' where id=2; - 修改多条表数据(限制)

  ​               表名             名称            值            名称       值   限制 id为2的将被修改

- delete from testtable where id='9'; - 删除部分表数据

  ​                      表名       限制id为9的将会被删除

- delete from testtable; - 删除这个表里面所有数据

  ​                   表名

- select * from testtable limit 3; - 查询表前3个数据

  ​                         表名     限制数量

- select * from testtable limit 2,3; - 查询指定表数据

  ​                         表名    限制 从第2条数据之后开始查询,查询3条数据

-  select username from testtable; - 查询表所有名称(可以跟限制limit,where,否则即所有)

  ​               名称                 表名

   例子: select username from testtable where id>12;       select username from testtable limit 2,3;       select username,password from testtable;

  ​                         名称                 表名       限制 条件                        名称                 表名     限制 条件                      名称     名称                   表名

- select * from testtable order by id; - 表正向查询(可以跟限制limit,否则即所有,INT类型按数字大小,字符按字母顺序)

  ​                         表名                名称

- select * from testtable order by id desc; - 表反向查询(可以跟限制limit,否则即所有)

  ​                         表名                名称 

- select first_name FFF  from actor; - 查询时暂时更改表头(更改的名字前可以不加关键字as)

  ​              名称      (as)更改名  表名

#### 静态语句

- select now(); - 查询当前时间

- select curdate(); - 查询当前日期

- select 1+1; - 查询时可附加运算

- select pi(); - 查询PiΠ值

- select mod(30,9); - 求余数

- select sqrt(25); - 求平方根

#### 运算符

- *
- /           - 除 结果为浮点数
- div       - 除 结果为整数
- % mod - 求余结果为浮点数
- +
- -

#### 常用功能函数

- round(5.57,1); - 四舍五入,重载保留1位小数
- floor(); - 直接舍
- ceiling(); - 直接入      (可以是表名称, 把表名称下所有的数据进行运算)

#### 字符操作

- concat('abc','123'); - 连接字符 例子:select concat(first_name,' ',last_name) Name from actor;

- left('abcdefg',2) - 取得前两位

- length('asd1231f') - 取得总长度

- reverse('asd1231f'); - 反转所有字符 : f1321dsa

- replace('asd1231f','d',''); - 替换字符

- date_format(); - 日期格式化 例子 : select date_format(payment_date,'%y/%m/%d') from payment limit 20;

  ​                                                                                              名称               格式             
  
  

