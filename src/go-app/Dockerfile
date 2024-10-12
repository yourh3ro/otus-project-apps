# Указываем базовый образ
FROM golang:1.23.2-alpine AS builder

# build stage
WORKDIR /app
COPY go.mod ./
RUN go mod download
COPY . .
RUN go build -o calculator ./cmd/main.go

# final stage
FROM alpine:latest
WORKDIR /root/
COPY --from=builder /app/calculator .
EXPOSE 8080
ENTRYPOINT ["./calculator"]
