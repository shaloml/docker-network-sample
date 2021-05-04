# docker-network-sample
1. create folders:
  - C:\logs
  - C:\sqlvolume

2. create networks:
  - name: db-layer, subnet 10.100.0.1/24
  - name: app-layer, subnet 10.200.0.1/24

3. add network db-layer on mssql container (Complete the command  on *****) 
	docker run --rm --name my-db -e ACCEPT_EULA="Y" -e SA_PASSWORD="SecretP@ssw0rd" -d ***** -v c:/sqlvolume/data:/var/opt/mssql/data -v c:/sqlvolume/log:/var/opt/mssql/log mcr.microsoft.com/mssql/server

4. create image from this git with:
  docker image  build -t app-net https://github.com/shaloml/docker-network-sample.git

5.create container, add network db-layer (Complete the command  on *****) 
  docker create ***** --name=my-app -v c:\logs:/logs -p:8001:80  app-net

6.Add db-layer Network as well  (Complete the command  on *****) 
  docker network connect *****

7. start container my-app

Wait 30 seconds...

8. Browse to: http://localhost:8001/Samurai

