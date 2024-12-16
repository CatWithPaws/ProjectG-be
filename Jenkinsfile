pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                echo 'Building projects'
                sh 'dotnet build'
                
            }
        }
        stage('Test') {
            steps {
                echo 'Testing TcpServer project'
                sh 'dotnet test TcpServer.Test  --results-directory ./Tests --logger:"nunit;LogFileName=GameServer.xml"'
                nunit testResultsPattern: 'Tests/GameServer.xml',failIfNoResults:'true',failedTestsFailBuild: 'true'

                echo 'Testing RestServer project'
                sh 'dotnet test RestServer.Test --results-directory ./Tests --logger:"nunit;LogFileName=RestServerTest.xml"'
                nunit testResultsPattern: 'Tests/RestServerTest.xml',failIfNoResults:'true',failedTestsFailBuild: 'true'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Sending deploy trigger to remote server'
                script{
                    withCredentials([
                        string(
                        credentialsId: 'Jenkins-ProjectG-BE-DeployUrl-Trigger',
                        variable: 'url')
                    ]) {
                        sh 'curl -X POST "$url"'

                    }
                }
            }
        }
    }
}