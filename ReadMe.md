# TcpClient-Lab

Web-application with the function to do TcpClient-calls, System.Net.Sockets.TcpClient. That way we can investigate TcpClient-calls when running in a container.

![.github/workflows/Docker-deploy.yml](https://github.com/HansKindberg-Lab/TcpClient-Lab/actions/workflows/Docker-deploy.yml/badge.svg)

Web-application, without configuration, pushed to Docker Hub: https://hub.docker.com/r/hanskindberg/tcpclient-lab

## LDAP-ports

- 389
- 636 (ldaps)
- 3268
- 3269 (ldaps)

## Configuration example for forwarded headers

	{
		"ForwardedHeaders": {
			"ForwardedHeaders": "All"
		}
	}