pipeline {
    agent any

    environment {
        MAVEN_HOME = "E:\\software\\apache-maven-3.9.6"
    }

    stages {
        stage('Checkout SCM') {
            steps {
                // Checkout SCM steps
                checkout scm
            }
        }
        
        stage('Build') {
            steps {
                // Build using Maven
                bat "${env.MAVEN_HOME}\\bin\\mvn clean install"
            }
        }
    }

    post {
        always {
            echo 'Pipeline execution completed'
        }
        
        success {
            // FindBugs plugin
            step([$class: 'FindBugsPublisher', canComputeNew: false, defaultEncoding: '', excludePattern: '', healthy: '', unHealthy: ''])
            // PMD plugin
            step([$class: 'PmdPublisher', canComputeNew: false, defaultEncoding: '', excludePattern: '', healthy: '', unHealthy: '', useStableBuildAsReference: true])
        }
    
        failure {
            // Actions to perform if the pipeline fails
            echo 'Pipeline execution failed!'
            // You can add more actions here
        }
    }
}
