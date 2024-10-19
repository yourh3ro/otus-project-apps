#!/bin/bash

# Список внешних IP-адресов ваших узлов
nodes=(
    "158.160.30.129"  # otus-k8s-worker-1
    "158.160.22.130"  # otus-k8s-worker-0
    "158.160.5.137"   # otus-k8s-master-0
    "158.160.23.218"  # otus-k8s-worker-2
)

# Укажите имя пользователя для SSH (например, ubuntu, centos, etc.)
user="yc-user"

for node in "${nodes[@]}"; do
    echo "Подключение к узлу: $node"
    
    ssh "$user@$node" << 'ENDSSH'
    sudo systemctl restart k3s*
ENDSSH

    echo "Завершено на узле: $node"
done

echo "Скрипт завершен."
