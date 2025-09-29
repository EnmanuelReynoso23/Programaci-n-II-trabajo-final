# Script para crear la base de datos y cargar toda la estructura
# Ejecutar en PowerShell como administrador

$PG_PATH = "C:\Program Files\PostgreSQL\17\bin\psql.exe"
$PORT = 2525
$USER = "postgres"
$DB = "sistema_inventario"

Write-Host "Creando base de datos si no existe..."
& $PG_PATH -p $PORT -U $USER -c "CREATE DATABASE $DB;" 2>$null

Write-Host "Creando esquemas..."
& $PG_PATH -p $PORT -U $USER -d $DB -c "CREATE SCHEMA IF NOT EXISTS database; CREATE SCHEMA IF NOT EXISTS stored_procedures; CREATE SCHEMA IF NOT EXISTS queries; CREATE SCHEMA IF NOT EXISTS docs;"

Write-Host "Ejecutando scripts de estructura..."


Write-Host "Listo. La base de datos está creada y lista para usar."