# otus-project-apps
###
go-app - Приложение калькулятор, которое возвращает сумму переданных аргументов
```
curl "http://localhost:8080/calculate?a=5&b=10"
{"result":15}
```
python-app - Эхо приложение на python + Flask
```
curl -X POST -H "Content-Type: application/json" -d '{"message": "hello"}' http://localhost:8080/echo
{"message":"hello"}
```
dotnet-app - dotnet 8.0 приложение, которое возвращает текст закодированный в base64
```
curl -X POST http://localhost:5000/api/encryption/encrypt -H "Content-Type: text/plain" -d "Hello, World!"
```

Так же каждое приложение умеет возвращать на GET /health - OK. Простой healthcheck
