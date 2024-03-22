pipeline {
    agent any

    stages {
        stage('Checkout SCM') {
            steps {
                // Checkout SCM steps
                checkout scm
            }
        }
        stage('Build') {
            steps {
                // Add build steps here
                // Example: Maven build
                bat 'mvn clean install'
            }
        }
        stage('Test') {
            steps {
                // Add test steps here
                // Example: Execute tests
                bat 'mvn test'
            }
        }
        stage('Deploy') {
            steps {
                // Add deployment steps here
                // Example: Deploy artifacts
                bat 'mvn deploy'
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
        always {
            // Actions to perform always, regardless of pipeline result
            echo 'Pipeline execution completed'
            // You can add cleanup actions here
        }
    }
}

// Trigger downstream job 'test' with a quiet period of 5 seconds
build job: 'test', quietPeriod: 5
