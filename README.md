# Swagger client generator for csharp clients for Red Hat JBoss Execution Server

Use this project to generate csharp clients for interacting with the KieServer in common ways:

* get containers
* start a process (with params)
* get process instances
* get tasks list
* claim a task
* start a task
* complete a task


### How to generate a client 

Command:

```sh
$ java -jar swagger-codegen-cli.jar generate -l csharp -t csharp-api-templates/ -i swagger-manage-tasks.yml -o /location/for/generated/code --api-package Generated.Api.Package.Name --model-package Generated.Model.Package.Name
```
