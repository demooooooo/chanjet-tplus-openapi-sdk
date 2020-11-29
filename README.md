# 畅捷通T+ OpenAPI SDK for .NET

一个简单易用的T+开放接口开发包。

使用此开发包，无需了解开放接口的底层细节，即可完成对T+系统的数据访问、服务调用，节省开发时间。

## 安装

下载项目文件并添加到你的解决方案中，记得添加项目引用。

## 获取Token

使用下面的代码获取Token

```c#
/// <summary>
/// 获取Token
/// </summary>
TPlusClient client = new TPlusClient(serverUrl, appKey, appSecret, privateKeyPath);
GetRealNameTPlusTokenRequest req = new GetRealNameTPlusTokenRequest
{
    UserName = "用户名",
    Password = "密码",
    AccNum = "账套"
};
var rsp = client.Execute(req);
if (!rsp.IsError)
{
    Console.WriteLine("access_token:" + rsp.AccessToken);
}
else
{
    Console.WriteLine("msg:" + rsp.Message);
}
```

## 业务调用

业务调用需要提供access_token

```c#
/// <summary>
/// 业务调用(仓库查询)
/// </summary>
TPlusClient client = new TPlusClient(serverUrl, appKey, appSecret, privateKeyPath);
QueryWarehouseRequest req = new QueryWarehouseRequest
{
    Param = new WarehouseEntityDTO
    {
        Code = "001",
        Name = "总仓",
        SelectFields = "ID,Code,Name"
    }
};
var rsp = client.Execute(req, access_token);
if (!rsp.IsError)
{
    foreach (var warehouse in rsp.Result)
    {
        Console.WriteLine("id:" + warehouse.ID);
        Console.WriteLine("code:" + warehouse.Code);
        Console.WriteLine("name:" + warehouse.Name);
    }
}
else
{
    Console.WriteLine("msg:" + rsp.Message);
}
```

## 其他资料

* 接口信息参考官方文档 http://tplusdev.chanjet.com/library/category/53c8742f1cb2b2f012202b8b
* T+开发QQ群 183150557

