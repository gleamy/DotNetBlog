## Readme
1. agent 目录下的 agent.cfg 配置文件中，配置好需要连接的 adapter ip地址和端口号。
   - 在这里我们配置本地的地址 127.0.0.1。
   - 端口号默认为 7878
   - 我们可以酌情配置多个，在这里我们配置三个。
2. 修改 agent 目录下面的 devices.xml 文件。
   - 将里面的devices节点复制成三份， 并调整名字（name）。

> 遇到问题，在agent当中配置三份同样的 device，只是ID和名称不同，在启动agent的时候，报 id和name重复的问题。

> 问题已经处理，在agent当中配置多个同样的device时，只需要将所有dataitem(所有的device下)的ID设置为唯一就可以了。不同device项目的name是可以重复的。