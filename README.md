# OnlineForum
Course 4 Final Work for Components of Programming Supplements

To create docker image, in root folder use this command:

	docker build -t forum .

To start docker image use this cammand:

	docker run -it -p 5000:80 --net=bridge --name ForumWeb forum

We should configure docker-compose, to automaticaly setup network for all containers and set env vars to newly created container ips, so they could comunicate(container to container communication).
For now we can check all containers ips by using this command:
	
	docker network inspect bridge