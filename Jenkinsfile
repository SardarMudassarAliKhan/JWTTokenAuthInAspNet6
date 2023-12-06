pipeline {
    agent any

   

    stages {
        stage('Build') {
            steps {
                script {
                    // Build Docker image
                    sh 'docker build --no-cache -t jwtms/api -f JWTTokenAuthInAspNet6/Dockerfile .'
                }
            }
        }

        stage('Push and Deploy') {
            steps {
                script {
                    // Stop and remove existing container (if any)
                    sh 'docker stop jwtms || true && docker rm jwtms || true'

                    // Run a new container with the built image
                    sh 'docker run -d --name jwtms -p 5001:80 --env "ASPNETCORE_ENVIRONMENT=Development" jwtms/api:latest'
                }
            }
        }
    }
}
