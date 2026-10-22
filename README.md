# Minimal API mit MongoDB

Ein .NET-Web-API-Projekt zur Einführung in die Entwicklung einer REST-API mit MongoDB und Docker.

## Beschreibung

Das Projekt **min-api-with-mongo** beschäftigt sich mit der Entwicklung einer Web-API und deren Anbindung an eine MongoDB-Datenbank.

Im Mittelpunkt stehen die Kommunikation zwischen einer API und einer NoSQL-Datenbank sowie die containerisierte Bereitstellung der Anwendung mithilfe von Docker Compose.

## Funktionen

- Bereitstellung einer Web-API
- Verbindung zu einer MongoDB-Datenbank
- Verwendung einer NoSQL-Datenbank zur Datenspeicherung
- Konfiguration der Datenbankverbindung über Umgebungsvariablen
- Containerisierung der API und Datenbank mit Docker
- Persistente Speicherung der MongoDB-Daten über ein Docker-Volume
- Gemeinsamer Start der Dienste mit Docker Compose

## Technologien

- .NET / ASP.NET Core
- REST API
- MongoDB
- Docker
- Docker Compose
- YAML

## Installation und Ausführung

### Voraussetzungen

- Docker
- Docker Compose
- Optional: Visual Studio oder Visual Studio Code

### 1. Repository klonen

```bash
git clone https://github.com/samad-pour/min-api-with-mongo.git
```

Anschliessend in das Projektverzeichnis wechseln:

```bash
cd min-api-with-mongo
```

### 2. Docker-Container starten

Die Anwendung und MongoDB können gemeinsam über Docker Compose gestartet werden:

```bash
docker compose up --build -d
```

Dabei werden die benötigten Container erstellt und gestartet.

### 3. Anwendung aufrufen

Die Web-API ist über den konfigurierten Port erreichbar:

```text
http://localhost:5001
```

Die verfügbaren API-Endpunkte hängen von der Implementierung ab.

### 4. Container stoppen

```bash
docker compose down
```

Die gespeicherten MongoDB-Daten bleiben im Docker-Volume erhalten.

## Docker-Konfiguration

Die Datei `docker-compose.yml` definiert zwei Dienste:

| Dienst | Beschreibung |
|---|---|
| `webapi` | Web-API zur Verarbeitung von HTTP-Anfragen |
| `mongodb` | MongoDB-Datenbank zur Datenspeicherung |

Die Datenbankverbindung erfolgt innerhalb des Docker-Netzwerks über den Hostnamen `mongodb`.

Die MongoDB-Daten werden im Volume `mongoData` gespeichert, damit sie auch nach einem Neustart der Container erhalten bleiben.

**Hinweis:** Die Beispielkonfiguration enthält fest hinterlegte Datenbank-Zugangsdaten. Für produktive Umgebungen sollten sichere Zugangsdaten und Umgebungsvariablen verwendet werden.

## Projektstruktur

```text
min-api-with-mongo/
├── WebApi/                 # Web-API-Anwendung
├── docker-compose.yml      # Docker-Konfiguration
├── .gitignore
└── README.md
```

## Ziel

Das Projekt dient dem Verständnis der Entwicklung und Bereitstellung einer Web-API mit MongoDB.

Dabei werden grundlegende Konzepte der REST-API-Entwicklung, der Arbeit mit NoSQL-Datenbanken, der Datenbankanbindung und der Containerisierung mit Docker kennengelernt.
